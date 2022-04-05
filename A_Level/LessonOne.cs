using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Level
{
    /// <summary>
    /// Домашнее задание к уроку №1.
    /// </summary>
    public class LessonOne
    {
        static LessonOne()
        {
            Console.WriteLine("HT Lesson 1");
            string name = "Andrew";
            string surname = "Kud";
            int age = 28;
            int forFourty = 40 - age;
            Console.WriteLine("Вас зовут {0} {1}, и до начала новой жизни вам осталось - {2} лет.", name, surname, forFourty);
        }
    }
}
