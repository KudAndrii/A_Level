using System;
using System.Text;

namespace ModuleTask
{
    internal class Program
    {
        private enum CindOfElements
        {
            Odd = 1,
            Even = 2
        }

        private static void Main(string[] args)
        {
            int[] array = GetIntArray();
            var oddNumbers = GetOddOrEvenNumbers(array, CindOfElements.Odd);
            var evenNumbers = GetOddOrEvenNumbers(array, CindOfElements.Even);
        }

        /// <summary>
        /// Method returns int array with given length.
        /// </summary>
        /// <returns>Int array with needed length.</returns>
        private static int[] GetIntArray()
        {
            uint n = 0;
            while (n == 0)
            {
                Console.Write("Enter the length of an array: ");
                uint.TryParse(Console.ReadLine(), out n);
            }

            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                result[i] = random.Next(1, 27);
            }

            return result;
        }

        /// <summary>
        /// Method returns odd or even elements of incoming array.
        /// </summary>
        /// <param name="incomingArray">Incoming int array.</param>
        /// <param name="neededElements">Cind of needed elements.</param>
        /// <returns>Int array of needed elements.</returns>
        private static int[] GetOddOrEvenNumbers(int[] incomingArray, CindOfElements neededElements)
        {
            int lengthOfResult = 0;
            foreach (var item in incomingArray)
            {
                if ((int)neededElements % 2 != 0)
                {
                    lengthOfResult++;
                }
                else
                {
                    lengthOfResult++;
                }
            }

            int[] result = new int[lengthOfResult];

            return result;
        }
    }
}
