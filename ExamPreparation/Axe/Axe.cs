using System;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var top = new string('-', 3 * n) + '*' + new string('-', i) + '*' + new string('-', (2 * n - 2) - i);
                Console.WriteLine(top);
            }
            for (int i = 0; i < n / 2; i++)
            {
                var mid = new string('*', 3 * n) + '*' + new string('-', n - 1) + '*' + new string('-', n - 1);
                Console.WriteLine(mid);
            }                                               
            for (int i = 0; i < n / 2; i++)                 
            {                                               
                if (i == n / 2 - 1)                         
                {
                    Console.WriteLine(new string('-', 3 * n - i) + '*' + new string('*', n - 1 + 2 * i) + '*' + new string('-', n - 1 - i));
                }
                else
                {
                    var blade = new string('-', 3 * n - i) + '*' + new string('-', n - 1 + 2 * i) + '*' + new string('-', n - 1 - i);
                    Console.WriteLine(blade);
                }
            }
        }
    }
}
