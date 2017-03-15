using System;

namespace FifthTaskStopFigure
{
    class StopFigure
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 2 * n + 2;

            Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n - i) + "//" + new string('_', 2 * n - 1 + 2 * i) + "\\" + "\\" + new string('.', n - i));
            }
            Console.WriteLine("//" + new string('_', 2 * n - 3) + "STOP!" + new string('_', 2 * n - 3) + "\\" + "\\");
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(new string('.', n - i) + "\\" + "\\" + new string('_', 2 * n - 1 + 2 * i) + "//" + new string('.', n - i));
            }
        }
    }
}
