using System;
using System.Collections.Generic;
using MyGeneric.MyListServices;

namespace MyGeneric
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(0);
            Show(list);
            int[] array = new int[] { 4, 2, 3, 1 };
            list.AddRange(array);
            Show(list);
            bool flag;
            list.Remove(1, out flag);
            Show(list, flag);
            list.RemoveAt(3);
            Show(list);
            list.Sort();
            Show(list);
        }

        private static void Show(MyList<int> list, bool flag = false)
        {
            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine();
            if (flag == false)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(flag);
            }
        }
    }
}
