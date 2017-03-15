using System;

namespace FifthTaskFox
{
    class Fox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var topPart = new string('*', i) + '\\' + new string('-', 2 * n + 1 - 2 * i) + '/' + new string('*', i);
                Console.WriteLine(topPart);
            }
            for (int i = 0; i < n / 3; i++)
            {
                var middlePart = '|' + new string('*', n / 2 + i) + '\\' + new string('*', n - 2 * i) + '/' + new string('*', n / 2 + i) + '|';
                Console.WriteLine(middlePart);
            }
            for (int i = 1; i <= n; i++)
            {
                var bottomPart = new string('-', i) + '\\' + new string('*', 2 * n + 1 - 2 * i) + '/' + new string('-', i);
                Console.WriteLine(bottomPart);
            }
        }
    }
}
