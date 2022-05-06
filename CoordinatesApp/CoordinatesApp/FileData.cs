using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoordinatesApp
{
    public sealed class FileData
    {
        private const string _path = @"..\..\..\";

        private const string _fileName = "coordinates.txt";

        private static readonly Lazy<FileData> Lazy = new Lazy<FileData>(() => new FileData());

        private static StringBuilder _text = new StringBuilder();

        public static FileData Instance
        {
            get { return Lazy.Value; }
        }

        public static void AddText(int i, int x, int y)
        {
            _text.Append($"A{i + 1}:({x},{y})");
            File.WriteAllText(_path + _fileName, _text.ToString());
        }
    }
}
