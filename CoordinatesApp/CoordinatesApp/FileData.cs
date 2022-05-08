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
        private readonly string _path = @"..\..\..\";

        private readonly string _fileName = "coordinates.txt";

        private int _numberOfPoint = 0;

        // 0-element is info about coordinates of points,
        // 1-element is info about all possible lenghts,
        // 2-element is info about minLenght.
        private List<StringBuilder> _pointsInfo = new List<StringBuilder>(3);

        private static readonly Lazy<FileData> Lazy = new Lazy<FileData>(() => new FileData());

        public static FileData Instance
        {
            get { return Lazy.Value; }
        }

        /// <summary>
        /// Method adding data about coordinates of points to the _pointsInfo[0].
        /// </summary>
        /// <param name="x">X-coordinates.</param>
        /// <param name="y">Y-coordinates.</param>
        public void AddText(int x, int y)
        {
            _numberOfPoint++;
            var coordinatesOfPoints = $"A{_numberOfPoint}:({x},{y}) ";
            if (_pointsInfo.Count == 0)
            {
                _pointsInfo.Add(new StringBuilder());
            }

            _pointsInfo[0].Append(coordinatesOfPoints);
        }

        /// <summary>
        /// Method adding data about lenghts between points to the _pointsInfo[1].
        /// </summary>
        /// <param name="numberOfFirstPoint">Number of first point.</param>
        /// <param name="numberOfSecondPoint">Number of second point.</param>
        /// <param name="length">Length between two points.</param>
        public void AddText(int numberOfFirstPoint, int numberOfSecondPoint, double length)
        {
            var lenghtsBetweenPoints = $"Lenghts from A{numberOfFirstPoint + 1} to A{numberOfSecondPoint + 1} is {length} ";
            if (_pointsInfo.Count <= 1)
            {
                _pointsInfo.Add(new StringBuilder());
            }

            _pointsInfo[1].Append(lenghtsBetweenPoints);
        }

        /// <summary>
        /// Method adding data about minimal lenght between all points.
        /// </summary>
        /// <param name="minLenght">Value of minimal lenght.</param>
        public void AddText(double minLenght)
        {
            if (_pointsInfo.Count <= 2)
            {
                _pointsInfo.Add(new StringBuilder());
            }

            _pointsInfo[2].Append(minLenght);
        }

        /// <summary>
        /// Method adding data from the _text to the file coordinatex.txt.
        /// </summary>
        public void RecordText()
        {
            File.WriteAllText(_path + _fileName, $"{_pointsInfo[0].ToString()}\n{_pointsInfo[1].ToString()}\n{_pointsInfo[2].ToString()}");
        }
    }
}
