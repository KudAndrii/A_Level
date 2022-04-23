using System;

namespace HomeTaskLessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = GetArray(20);
            int resultOfFirstPart = GetNumberOfElements(A);
            int[] B = GetSecondArray(A);
            SortArray(B);
        }
        /// <summary>
        /// Method returns an int array of random elements.
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
        /// <summary>
        /// Method returns an int array, whose elements <= 888. 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] GetSecondArray(int[] array)
        {
            int[] result = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 888)
                    result[i] = array[i];
            }
            return result;
        }
        /// <summary>
        /// Method sorts elements in descending order.
        /// </summary>
        /// <param name="array"></param>
        static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        int k = array[j];
                        array[j] = array[i];
                        array[i] = k;
                    }
                }
            }
        }
    }
}
