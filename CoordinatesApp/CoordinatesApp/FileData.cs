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

        private static StringBuilder _pointsCoordinates = new StringBuilder();
        private static StringBuilder _lenghtsBetweenPoints = new StringBuilder("\n");
        private static string _minLenght = "\n";

        public static FileData Instance
        {
            get { return Lazy.Value; }
        }

        /// <summary>
        /// Method adding data about points to the _pointsCoordinates.
        /// </summary>
        /// <param name="numberOfPoint">Number of point.</param>
        /// <param name="x">X-coordinates.</param>
        /// <param name="y">Y-coordinates.</param>
        public static void AddText(int numberOfPoint, int x, int y)
        {
            _pointsCoordinates.Append($"A{numberOfPoint + 1}:({x},{y})");
        }

        /// <summary>
        /// Method adding data about lenghts between points to the _lenghtsBetweenPoints.
        /// </summary>
        /// <param name="numberOfFirstPoint">Number of first point.</param>
        /// <param name="numberOfSecondPoint">Number of second point.</param>
        /// <param name="length">Length between two points.</param>
        public static void AddText(int numberOfFirstPoint, int numberOfSecondPoint, double length)
        {
            _lenghtsBetweenPoints.Append($"Lenghts from A{numberOfFirstPoint + 1} to A{numberOfSecondPoint + 1} is {length} ");
        }

        public static void AddText(double minLenght)
        {
            _minLenght += minLenght;
        }

        /// <summary>
        /// Method adding data from the _text to the file coordinatex.txt.
        /// </summary>
        public static void RecordText()
        {
            File.WriteAllText(_path + _fileName, _pointsCoordinates.ToString() + _lenghtsBetweenPoints.ToString() + _minLenght);
        }
    }
}
