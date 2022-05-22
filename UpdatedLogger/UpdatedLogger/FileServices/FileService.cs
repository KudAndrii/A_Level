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
        private string _fileName;
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
            _fileName = DateTime.Now.ToString();
            File.Create(_path + _fileName + ".txt");
        }

        public void AddToFile(string log)
        {
            File.WriteAllText(_path + _fileName + ".txt", log);
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
