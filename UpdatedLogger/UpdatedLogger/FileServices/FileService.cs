using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdatedLogger.Interfaces;

namespace UpdatedLogger.FileServices
{
    internal class FileService : IFileService
    {
        private string _path;
        private StringBuilder _fileName = new StringBuilder();
        private IConfigService _configService;
        public FileService(IConfigService configService)
        {
            _configService = configService;
            _path = _configService.GetPath();
            if (CheckLogFilesCount())
            {
                CreateFile();
            }
            else
            {
                DeleteOldFile();
                CreateFile();
            }
        }

        public void CreateFile()
        {
            _fileName.Append(DateTime.Now.ToString());
            _fileName.Replace(':', '.');
            using (File.Create(_path + _fileName.ToString() + ".txt"))
            {
            }
        }

        public void AddToFile(string log)
        {
            File.AppendAllText(_path + _fileName + ".txt", log + "\n");
        }

        public bool CheckLogFilesCount()
        {
            if (Directory.GetFiles(_path).Length < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteOldFile()
        {
        }
    }
}
