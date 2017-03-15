using System;

namespace FifthTaskRocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var top = new string('.', (3 * n - 2) / 2 - i) + '/' + new string(' ', 2 * i) + '\\' + new string('.', (3 * n - 2) / 2 - i);
                Console.WriteLine(top);
            }
            Console.WriteLine(new string('.', n / 2) + new string('*', n * 2) + new string('.', n / 2));
            for (int i = 0; i < 2 * n; i++)
            {
                var middle = new string('.', n / 2) + '|' + new string('\\', 2 * n - 2) + '|' + new string('.', n / 2);
                Console.WriteLine(middle);
            }
            for (int i = 0; i < n / 2; i++)
            {
                var bottom = new string('.', n / 2 - i) + '/' + new string('*', 2 * (n - 1 + i)) + '\\' + new string('.', n / 2 - i);
                Console.WriteLine(bottom);
            }
    }
}
