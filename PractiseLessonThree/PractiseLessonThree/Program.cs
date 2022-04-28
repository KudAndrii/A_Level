using System;
using System.Collections.Generic;
using System.Text;

namespace PractiseLessonThree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = GetStringWithSpecialConditions();
            Console.WriteLine("Start input: " + input);
            DeleteNumbersInString(ref input);
            Console.WriteLine("Numbers removed: " + input);
            ReverseOddWords(ref input);
            Console.WriteLine("Every odd word was reversed: " + input);
            EveryFirstLetterToUpper(ref input);
            Console.WriteLine("First letters of all words in upper register: " + input);
            ChangeNeededLetters(ref input);
            Console.WriteLine("Needed letters has been changed: " + input);
        }

        /// <summary>
        /// Check the conditions of input.
        /// </summary>
        /// <returns>Needed string.</returns>
        private static string GetStringWithSpecialConditions()
        {
            Console.WriteLine("Enter the sentence:");

            string result = Console.ReadLine();
            while (result.Contains("  "))
            {
                result = result.Replace("  ", " ");
            }

            var words = result.Split(' ');
            if (words.Length < 5)
            {
                GetStringWithSpecialConditions();
            }

            return result;
        }

        /// <summary>
        /// Delete numbers from input string.
        /// </summary>
        private static void DeleteNumbersInString(ref string input)
        {
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '0' || sb[i] == '1' || sb[i] == '2' || sb[i] == '3' || sb[i] == '4' || sb[i] == '5' || sb[i] == '6' || sb[i] == '7' || sb[i] == '8' || sb[i] == '9')
                {
                    sb.Remove(i, 1);
                }
            }

            input = sb.ToString();
        }

        /// <summary>
        /// Reverse letters in every odd word in sentence.
        /// </summary>
        private static void ReverseOddWords(ref string input)
        {
            var words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char[] word = words[i].ToCharArray();
                    Array.Reverse(word);
                    words[i] = string.Concat<char>(word);
                }
            }

            StringBuilder sb = new StringBuilder(input.Length);
            foreach (var item in words)
            {
                sb.Append(item + " ");
            }

            sb.Remove(sb.Length - 1, 1);
            input = sb.ToString();
        }

        /// <summary>
        /// Transform first letters of all words in upper register.
        /// </summary>
        private static void EveryFirstLetterToUpper(ref string input)
        {
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < sb.Length; i++)
            {
                if ((i == 0) || sb[i - 1] == ' ')
                {
                    sb.Replace(sb[i], char.ToUpper(sb[i]), i, 1);
                }
            }

            input = sb.ToString();
        }

        /// <summary>
        /// StartWord letter P => S, EndWord letter N => O, dont count the register of old letters.
        /// </summary>
        private static void ChangeNeededLetters(ref string input)
        {
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[0] == 'P' || (sb[i] == 'P' && sb[i - 1] == ' '))
                {
                    sb[i] = 'S';
                }

                if ((sb[i] == 'n' || sb[i] == 'N') && sb[i + 1] == ' ')
                {
                    sb[i] = 'O';
                }
            }

            input = sb.ToString();
        }
    }
}
