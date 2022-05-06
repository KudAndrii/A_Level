using System;
using System.Collections.Generic;

namespace CoordinatesApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Point> points = GetPoints(10);
            var dataAboutLenghts = GetAllPossibleLengthsAndCountMinValue(points);
            FileData.AddText(dataAboutLenghts.minLenght);
            FileData.RecordText();
        }

        /// <summary>
        /// Method returns list of points with random coordinates.
        /// </summary>
        /// <param name="count">Amount of points.</param>
        /// <returns>List of points.</returns>
        private static List<Point> GetPoints(int count)
        {
            List<Point> points = new List<Point>(count);
            for (int i = 0; i < 10; i++)
            {
                Point point = default;
                point.SetCoordinatesRandomly();
                points.Add(point);
                FileData.AddText(i, point.X, point.Y);
            }

            return points;
        }

        /// <summary>
        /// Method counts all possible lengths between all points and the minimum value.
        /// </summary>
        /// <param name="points">Incoming list of points.</param>
        /// <returns>All possible lenghts like a list of double and the minimum valuelike a double.</returns>
        private static (List<double> lenghts, double minLenght) GetAllPossibleLengthsAndCountMinValue(List<Point> points)
        {
            List<double> lenghts = new List<double>();
            double minLenght = double.MaxValue;
            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    int catet1 = Math.Abs(points[i].X - points[j].X);
                    int catet2 = Math.Abs(points[i].Y - points[j].Y);
                    double length = Math.Sqrt((catet1 * catet1) + (catet2 * catet2));
                    length = Math.Round(length, 2);
                    lenghts.Add(length);
                    FileData.AddText(i, j, length);
                }
            }

            foreach (var lenght in lenghts)
            {
                if (lenght < minLenght)
                {
                    minLenght = lenght;
                }
            }

            return (lenghts, minLenght);
        }
    }
}
