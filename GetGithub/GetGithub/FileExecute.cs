using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGithub
{
    public class FileExecute : AbstractExecutor
    {
        private volatile bool _executed = false;
        private readonly string _relativePath;
        public FileExecute(string url, string relativePath, Project project) : base(url, project)
        {
            _relativePath = relativePath;
        }


        public override void Execute()
        {
            if (_executed)
                return;

            lock (this)
            {
                if (_executed)
                    return;
                try
                {
                    string filePath = _project.GetFilePath(_relativePath);
                    if (!string.IsNullOrEmpty(filePath))
                        _httpHelper.WriteToFile(filePath, _url);
                }
                catch (Exception ex)
                {
                    _log.Log(_url);
                    _log.Log(ex);
                }
                _executed = true;
            }
        }
    }
}
