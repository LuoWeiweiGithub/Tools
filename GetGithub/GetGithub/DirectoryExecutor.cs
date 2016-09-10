using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.RegularExpressions;
using Dyllan.Common.Utility;

namespace GetGithub
{
    public class DirectoryExecutor : AbstractExecutor
    {
        private const string MatchTable = @"<table class=\""files js-navigation-container js-active-navigation-container\""[\w\W\s\S]*</table>";
        private static Regex matchTableRegex = new Regex(MatchTable);

        public DirectoryExecutor(string url, Project project): base(url, project)
        {
        }

        private volatile bool _isAnalyzed = false;
        private void Analyze()
        {
            if (_isAnalyzed)
                return;

            lock(this)
            {
                if (_isAnalyzed)
                    return;

                try
                {
                    Match match = matchTableRegex.Match(_htmlContent);
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(match.Value.Replace("data-pjax>", ">"));
                    XmlNodeList iconNodes = xmlDoc.DocumentElement.SelectNodes("//td[@class='icon']");
                    if (iconNodes != null && iconNodes.Count > 0)
                    {
                        foreach (XmlNode iconNode in iconNodes)
                        {
                            CreateExecutor(iconNode);
                        }
                    }
                }
                catch(Exception ex)
                {
                    _log.Log(_url);
                    _log.Log(ex);
                }

                _isAnalyzed = true;
            }
        }

        private void CreateExecutor(XmlNode iconNode)
        {
            if (iconNode == null)
                return;

            string svgClassName = string.Empty;
            XmlNode svgNode = iconNode.SelectSingleNode("svg");
            if (svgNode != null && svgNode.Attributes != null && svgNode.Attributes["class"] != null)
            {
                svgClassName = svgNode.Attributes["class"].Value;
            }

            switch (svgClassName)
            {
                case "octicon octicon-file-directory":
                    string directoryUrl = GetUrl(iconNode);
                    if (!string.IsNullOrEmpty(directoryUrl))
                    {
                        DirectoryExecutor executor = new DirectoryExecutor(_project.GetDirectoryUrl(directoryUrl), _project);
                        Executors.Add(executor);
                    }
                    break;
                case "octicon octicon-file-text":
                    string fileUrl = GetUrl(iconNode);
                    if (!string.IsNullOrEmpty(fileUrl))
                        Executors.Add(new FileExecute(_project.GetFileUrl(fileUrl), fileUrl, _project));
                    break;
                default:
                    break;
            }
        }

        private string GetUrl(XmlNode iconNode)
        {
            string result = string.Empty;
            if (iconNode == null)
                return result;

            XmlNode nextSibling = iconNode.NextSibling;
            while (nextSibling != null)
            {
                if (nextSibling.Attributes != null && nextSibling.Attributes["class"] != null && nextSibling.Attributes["class"].Value == "content")
                {
                    XmlNode aNode = nextSibling.SelectSingleNode("./span/a");
                    if (aNode != null && aNode.Attributes != null && aNode.Attributes["href"] != null)
                        result = aNode.Attributes["href"].Value;
                    break;
                }
                nextSibling = iconNode.NextSibling;
            }

            return result;
        }

        public override void Execute()
        {
            base.Execute();
            Analyze();
        }

        private HashSet<AbstractExecutor> _executors = new HashSet<AbstractExecutor>();
        public HashSet<AbstractExecutor> Executors
        {
            get
            {
                return _executors;
            }
        }
    }
}
