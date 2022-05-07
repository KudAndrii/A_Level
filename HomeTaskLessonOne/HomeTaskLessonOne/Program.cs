using System;

namespace HomeTaskLessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Andrew";
            string surname = "Kud";
            int age = 28;
            int toHundred = 100 - age;
            Console.WriteLine($"{name} {surname}, you have {toHundred} years to 100");
        }
    }
}
