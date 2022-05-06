using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesApp
{
    internal struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        /// <summary>
        /// Method allows to set coordinates from the console.
        /// </summary>
        public void SetCoordinatesFromConsole()
        {
            Console.Write("X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Y: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        /// <summary>
        /// Method allows to set coordinates randomly in the range from int.MinValue to int.MaxValue.
        /// </summary>
        public void SetCoordinatesRandomly()
        {
            Random random = new Random();
            X = random.Next(int.MinValue, int.MaxValue);
            Y = random.Next(int.MinValue, int.MaxValue);
        }
    }
}
