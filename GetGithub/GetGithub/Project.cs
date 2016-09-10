using Dyllan.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetGithub
{
    public class Project : IEnumerable<AbstractExecutor>
    {
        private static HashSet<string> _ignoreList = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
        private static string _saveFolder;

        static Project()
        {
            string ignoreList = AppSettingHelper.GetString("IgnoreList", string.Empty);
            string[] ignores = ignoreList.Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries);
            if (ignores != null && ignores.Length > 0)
            {
                foreach (string ignore in ignores)
                    _ignoreList.Add(ignore);
            }
            _saveFolder = AppSettingHelper.GetString("SaveFloder", Environment.CurrentDirectory);
        }

        private readonly string _projectHost;

        public string Host
        {
            get
            {
                return "https://github.com";
            }
        }

        public string ProjectHost
        {
            get
            {
                return _projectHost;
            }
        }

        public string RawTextHost
        {
            get
            {
                return "https://raw.githubusercontent.com";
            }
        }

        private readonly string _relativePath;
        private readonly string _oldRelativePath;

        public Project(string projectUrl)
        {
            _projectHost = projectUrl.TrimEnd('/');
            _relativePath = string.Format("{0}/", projectUrl.Replace(Host, "").Trim('/'));
            _oldRelativePath = string.Format("{0}blob/", _relativePath);
            enumerator = new ExecutorEnumerator(new DirectoryExecutor(projectUrl, this));
        }

        public string GetDirectoryUrl(string src)
        {
            return string.Format("{0}/{1}", Host, src.TrimStart('/'));
        }

        public string GetFileUrl(string path)
        {
            return string.Format("{0}/{1}", RawTextHost, path.Replace(_oldRelativePath, _relativePath).TrimStart('/'));
        }

        public string GetFilePath(string path)
        {
            string filePath = string.Format("{0}/{1}", _saveFolder, path);
            FileInfo fileInfo = new FileInfo(filePath);
            if (_ignoreList.Contains(fileInfo.Extension))
                filePath = string.Empty;
            return filePath;
        }

        private IEnumerator<AbstractExecutor> enumerator;
        public IEnumerator<AbstractExecutor> GetEnumerator()
        {
            return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return enumerator;
        }
    }
}
