using System;

namespace SixthTaskMagicNumbers
{
    class MagicNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = new string('*', n - 2);
            var dashes = new string('-', n - 2);

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(stars + '\\' + ' ' + '/' + stars);
                }
                else
                {
                    Console.WriteLine(dashes + '\\' + ' ' + '/' + dashes);
                }
            }
            Console.WriteLine(new string(' ', n - 1) + '@');
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(stars + '/' + ' ' + '\\' + stars);
                }
                else
                {
                    Console.WriteLine(dashes + '/' + ' ' + '\\' + dashes);
                }
            }
        }
    }
}
