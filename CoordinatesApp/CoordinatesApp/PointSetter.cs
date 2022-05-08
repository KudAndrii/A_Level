using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesApp
{
    internal class PointSetter
    {
        /// <summary>
        /// Method allows to set coordinates from the console.
        /// </summary>
        /// <param name="info">Information about which of coordinates should be setted.</param>
        /// <returns>Integer which had to be entered via console.</returns>
        public int SetCoordinatesFromConsole(string info)
        {
            Console.Write(info);
            int result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return result;
        }

        /// <summary>
        /// Method allows to set coordinates randomly in the range from int.MinValue to int.MaxValue.
        /// </summary>
        /// <returns>Random int from -1000 to 1000.</returns>
        public int SetCoordinatesRandomly()
        {
            Random random = new Random();
            int result = random.Next(-1000, 1000);
            return result;
        }
    }
}
