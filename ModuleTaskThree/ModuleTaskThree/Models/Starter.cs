using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleTaskThree.Abstractions;

namespace ModuleTaskThree.Models
{
    internal class Starter
    {
        public Starter()
        {
            Logger.Instance.BackupHandler += (string massage) => Console.WriteLine(massage);
        }
    }
}
