using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using UpdatedLogger.Interfaces;
using UpdatedLogger.DIcontainer;

namespace UpdatedLogger.FileServices
{
    internal class FileService : IFileService
    {
        private static readonly Lazy<FileService> Lazy = new Lazy<FileService>(()
            => new FileService(new Container().Load().GetService<IConfigService>()));
        private string _path;
        private StringBuilder _fileName = new StringBuilder();
        private IConfigService _configService;

        private FileService(IConfigService configService)
        {
            _configService = configService;
            _path = _configService.GetPath();
            if (CheckLogFilesCount())
            {
                CreateFile();
            }
            else
            {
                while (!CheckLogFilesCount())
                {
                    DeleteOldFile();
                }

                CreateFile();
            }
        }

        public static FileService Instance
        {
            get { return Lazy.Value; }
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
            var files = Directory.GetFiles(_path);
            string extraFile = files[0];
            foreach (var file in files)
            {
                for (int i = 1; i < file.Length; i++)
                {
                    if (file[i] == ' ' || file[i] == '.')
                    {
                        continue;
                    }
                    else if ((int)file[i] < (int)extraFile[i])
                    {
                        extraFile = file;
                        break;
                    }
                }
            }

            // "C:\Users\cudan\Documents\GitHub\A_Level\UpdatedLogger\UpdatedLogger\Logs\23.05.2022 20.04.20.txt"
            File.Delete(extraFile);
        }
    }
}
