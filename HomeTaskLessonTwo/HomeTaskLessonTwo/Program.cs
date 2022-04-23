using System;

namespace HomeTaskLessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArray(10);
            int resultOfFirstPart = GetNumberOfElements(array);
        }
        /// <summary>
        /// Method returns int array of random elements.
        /// </summary>
        /// <param name="N">length of array</param>
        /// <returns></returns>
        static int[] GetArray(int N)
        {
            int[] array = new int[N];
            var random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-1000, 1000);
            }

            return array;
        }
        /// <summary>
        /// Method returns count of elements in range -100...100.
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns></returns>
        static int GetNumberOfElements(int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                if (item >= -100 && item <= 100)
                    result++;
            }

            return result;
        }
    }
}
