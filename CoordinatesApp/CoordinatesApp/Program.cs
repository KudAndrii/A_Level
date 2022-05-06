using System;
using System.Collections.Generic;
using System.IO;

namespace CoordinatesApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Point point = default;
                point.SetCoordinatesRandomly();
                FileData.AddText(i, point.X, point.Y);
            }
        }
    }
}
