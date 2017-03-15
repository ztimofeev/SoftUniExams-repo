using System;

namespace FifthTaskDiamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var  n = int.Parse(Console.ReadLine());

            var topRow = new string('.', n) + new string('*', 3 * n) + new string('.', n);
            var bottomRow = new string('*', 5 * n);

            Console.WriteLine(topRow);
            for (int i = 0; i < n - 1; i++)
            {
                var middleRows = new string('.', n - i - 1) + '*' + new string('.', 3 * n + 2 * i) + '*' + new string('.', n - i - 1);
                Console.WriteLine(middleRows);
            }
            Console.WriteLine(bottomRow);

            for (int i = 1; i <= 2 * n; i++)
            {
                var downPart = new string('.', i) + '*' + new string('.', 5 * n - (2 + 2 * i)) + '*' + new string('.', i);
                Console.WriteLine(downPart);
            }

            var baseRow = new string('.', 2 * n + 1) + new string('*', n - 2) + new string('.', 2 * n + 1);
            Console.WriteLine(baseRow);
        }
    }
}
