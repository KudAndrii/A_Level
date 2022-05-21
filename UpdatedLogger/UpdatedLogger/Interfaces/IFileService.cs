using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedLogger.Interfaces
{
    public interface IFileService
    {
        public void AddToFile();
        public bool CheckLogFilesCount();
        public void DeleteOldFile();
    }
}
