using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level
{
    /// <summary>
    /// Домашнее задание к уроку №2.
    /// </summary>
    public class LessonTwo
    {
        static LessonTwo()
        {
            Console.WriteLine("HT Lesson 2");
            int[] arrayHT2 = GenerateArray(20);
            int countOfNeededNumbers = CountOfNumbers(arrayHT2);
            Console.Write("arrayHT2: \t");
            for (int i = 0; i < arrayHT2.Length; i++)
            {
                Console.Write(arrayHT2[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine($"Количество чисел массива в диапазоне -100...+100: {countOfNeededNumbers}.");
            int[] newArrayHT2 = NewArray(arrayHT2);
            Console.Write("newArrayHT2: \t");
            for (int i = 0; i < newArrayHT2.Length; i++)
            {
                Console.Write(newArrayHT2[i] + "\t");
            }

            Console.WriteLine();
        }

        // случайная генерация массива целых чисел заданной длины (по умоланию 20 элементов)
        private static int[] GenerateArray(int n = 20)
        {
            int[] array = new int[n];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-150, 1000);
            }

            return array;
        }

        // возврат количества элементов входящего массива, которые находятся в диапазоне -100...+100
        private static int CountOfNumbers(int[] array)
        {
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 100 && array[i] >= -100)
                {
                    x++;
                }
            }

            return x;
        }

        // создание нового массива с условием, что каждый элемент массива <= 888, и сортировка его по убыванию
        private static int[] NewArray(int[] a)
        {
            int length = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 888)
                {
                    length++;
                }
            }

            int[] b = new int[length];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 888)
                {
                    b[k] = a[i];
                    k++;
                }
            }

            for (int i = 0; i < b.Length - 1; i++)
            {
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i] < b[j])
                    {
                        int x;
                        x = b[i];
                        b[i] = b[j];
                        b[j] = x;
                    }
                }
            }

            return b;
        }
    }
}
