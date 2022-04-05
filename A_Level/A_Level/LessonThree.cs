using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level
{
    /// <summary>
    /// HT for lesson №3.
    /// </summary>
    public class LessonThree
    {
        static LessonThree()
        {
            string text = string.Empty;
            int spaceCount = 0;
            while (spaceCount < 4)
            {
                Console.WriteLine("Введите ваше предложение, которое должно состоять минимум из 5ти слов");
                text = Console.ReadLine();
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                    {
                        spaceCount++;
                    }
                }

                if (spaceCount < 4)
                {
                    Console.WriteLine("Количество пробелов в предложении должно быть не менее 4х");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("Задача №1 домашнего задания:");
            text = DeleteNumbers(text);
            Console.WriteLine(text);
            text = ReverseOddWords(text);
            Console.WriteLine(text);
            text = FirsLetterToUpper(text);
            Console.WriteLine(text);
            text = ChangeLetters(text);
            Console.WriteLine(text);
        }

        // delete all numbers and empty entries from sentence
        private static string DeleteNumbers(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '0' || sb[i] == '1' || sb[i] == '2' || sb[i] == '3' || sb[i] == '4' || sb[i] == '5' || sb[i] == '6' || sb[i] == '7' || sb[i] == '8' || sb[i] == '9')
                {
                    sb.Remove(i, 1);
                }
            }

            sb.Replace("  ", " ");
            text = sb.ToString();
            return text;
        }

        // reverse all odd words
        private static string ReverseOddWords(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i = i + 2)
            {
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);
                words[i] = new string(word);
            }

            StringBuilder sb = new StringBuilder(words.Length);
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i] + " ");
            }

            sb.Remove(sb.Length - 1, 1);
            text = sb.ToString();
            return text;
        }

        // first letter of every word toUpper
        private static string FirsLetterToUpper(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i < sb.Length; i++)
            {
                if (i == 0 || sb[i - 1] == ' ')
                {
                    sb[i] = char.ToUpper(sb[i]);
                }
            }

            text = sb.ToString();
            return text;
        }

        // changing first letters of words p/P => S и n/N => O
        private static string ChangeLetters(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i < sb.Length; i++)
            {
                if ((i == 0 || sb[i - 1] == ' ') && (sb[i] == 'p' || sb[i] == 'P'))
                {
                    sb.Replace(sb[i], 'S');
                }

                if ((i == 0 || sb[i - 1] == ' ') && (sb[i] == 'n' || sb[i] == 'N'))
                {
                    sb.Replace(sb[i], 'O');
                }
            }

            text = sb.ToString();
            return text;
        }
    }
}
