using System;
using System.Text;

namespace ModuleTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = GetIntArray();
            var oddNumbers = GetOddOrEvenNumbers(array);
            var evenNumbers = GetOddOrEvenNumbers(array, true);
            var firstCharArray = ChangeNumbersOnLetters(oddNumbers);
            var secondCharArray = ChangeNumbersOnLetters(evenNumbers);
            SomeLettersToUpper(ref firstCharArray);
            SomeLettersToUpper(ref secondCharArray);
            CompareArraysByUpperLetters(firstCharArray, secondCharArray);
            Console.WriteLine("This is the first array: " + string.Join(' ', firstCharArray));
            Console.WriteLine("This is the second array: " + string.Join(' ', secondCharArray));
        }

        /// <summary>
        /// Method returns int array with given length.
        /// </summary>
        /// <returns>Int array with needed length.</returns>
        private static int[] GetIntArray()
        {
            int n = default;
            Console.Write("Enter the length of an array: ");
            int.TryParse(Console.ReadLine(), out n);
            if (n <= 0)
            {
                Console.WriteLine("Incoming data is not correct");
                Console.ReadKey();
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
        /// <param name="getEvenElements">Bool variable to identify kind of elements which you need.</param>
        /// <returns>Int array of needed elements.</returns>
        private static int[] GetOddOrEvenNumbers(int[] incomingArray, bool getEvenElements = false)
        {
            int lengthOfResult = 0;
            foreach (var item in incomingArray)
            {
                if (getEvenElements && item % 2 == 0)
                {
                    lengthOfResult++;
                }
                else if (!getEvenElements && item % 2 != 0)
                {
                    lengthOfResult++;
                }
            }

            int[] result = new int[lengthOfResult];
            int resultIterator = 0;
            for (int i = 0; i < incomingArray.Length; i++)
            {
                if (getEvenElements && incomingArray[i] % 2 == 0)
                {
                    result[resultIterator] = incomingArray[i];
                    resultIterator++;
                }
                else if (!getEvenElements && incomingArray[i] % 2 != 0)
                {
                    result[resultIterator] = incomingArray[i];
                    resultIterator++;
                }
            }

            return result;
        }

        /// <summary>
        /// Method returns char array, based on incoming int array.
        /// </summary>
        /// <param name="array">Incoming int array.</param>
        /// <returns>Resulting char array.</returns>
        private static char[] ChangeNumbersOnLetters(int[] array)
        {
            char[] result = new char[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                // Сalculation of the integer value of a character,
                // taking into account its serial number in the English alphabet
                result[i] = (char)(array[i] + (int)'A' - 1);
                result[i] = char.ToLower(result[i]);
            }

            return result;
        }

        /// <summary>
        /// Method changing letters (a,e,i,d,h,j) to upper register.
        /// </summary>
        /// <param name="array">Incoming array.</param>
        private static void SomeLettersToUpper(ref char[] array)
        {
            char[] toUpperLetters = { 'a', 'e', 'i', 'd', 'h', 'j' };
            StringBuilder sb = new StringBuilder(array.Length);
            sb.Append(array);
            for (int i = 0; i < sb.Length; i++)
            {
                if (string.Concat(toUpperLetters).Contains(sb[i]))
                {
                    sb[i] = char.ToUpper(sb[i]);
                }
            }

            array = sb.ToString().ToCharArray();
        }

        /// <summary>
        /// Method compare two arrays, and show which contain more letters in upper register.
        /// </summary>
        /// <param name="firstArray">First array for comparison.</param>
        /// <param name="secondArray">Second array to comparison.</param>
        private static void CompareArraysByUpperLetters(char[] firstArray, char[] secondArray)
        {
            int firstCount = CountUpperChars(firstArray);
            int secondCount = CountUpperChars(secondArray);

            // Helper method to count letters in upper register.
            int CountUpperChars(in char[] array)
            {
                int result = default;
                foreach (var item in array)
                {
                    if (item == char.ToUpper(item))
                    {
                        result++;
                    }
                }

                return result;
            }

            if (firstCount > secondCount)
            {
                Console.WriteLine("First array contains more letters in upper register then second");
            }
            else if (secondCount > firstCount)
            {
                Console.WriteLine("Second array contains more letters in upper register then first");
            }
            else
            {
                Console.WriteLine("It's a miracle, bouth arrays contains equals count of letters in upper register");
            }
        }
    }
}
