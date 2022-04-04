using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level
{
    /// <summary>
    /// Домашнее задание к уроку №3.
    /// </summary>
    public class LessonThree
    {
        static LessonThree()
        {
            string text = " ";
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
            text = ReverseOddWords(text);
            text = FirsLetterToUpper(text);
            text = ChangeLetters(text);
            Console.WriteLine(text);
        }

        // удаляет все цифры и лишние пробелы из предложения
        private static string DeleteNumbers(string text)
        {
            char[] str = new char[text.Length];
            int iterator = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0' || text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' || text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i] == '8' || text[i] == '9')
                {
                    iterator++;
                    continue;
                }
                else
                {
                    str[i - iterator] = text[i];
                }
            }

            text = Convert.ToString(str[0]);
            for (int i = 1; i < str.Length - iterator; i++)
            {
                text += str[i];
            }

            return text;
        }

        // разворачивает каждое второе слово
        private static string ReverseOddWords(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i = i + 2)
            {
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);
                words[i] = new string(word);
            }

            text = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                text += " " + words[i];
            }

            return text;
        }

        // первая буква каждого слова в верхний регистр
        private static string FirsLetterToUpper(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                word[0] = char.ToUpper(word[0]);
                words[i] = new string(word);
            }

            text = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                text += " " + words[i];
            }

            return text;
        }

        // замена букв p/P => S и n/N => O
        private static string ChangeLetters(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                if (word[0] == 'p' || word[0] == 'P')
                {
                    word[0] = 'S';
                }
                else if (word[0] == 'n' || word[0] == 'N')
                {
                    word[0] = 'O';
                }

                words[i] = new string(word);
            }

            text = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                text += " " + words[i];
            }

            return text;
        }
    }
}
