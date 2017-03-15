using System;

namespace FifthTaskChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var top1 = new string('.', 2 * n - 1) + "/|\\" + new string('.', 2 * n - 1);
            var top2 = new string('.', 2 * n - 1) + "\\|/" + new string('.', 2 * n - 1);

            Console.WriteLine(top1);
            Console.WriteLine(top2);

            for (int i = 0; i < 2 * n; i++)
            {
                var mid = new string('.', 2 * n - 1 - i) + "*" + new string('-', i) + "*" + new string('-', i) + "*" + new string('.', 2 * n - 1 - i);
                Console.WriteLine(mid);
            }

            Console.WriteLine(new string('*', 4 * n + 1));
            Console.WriteLine(MagicStr("*.", 2 * n) + '*');
            Console.WriteLine(new string('*', 4 * n + 1));

        }

        public static String MagicStr(string txt, int count)
        {
            var output = "";
            for (int i = 0; i < count; i++)
            {
                output += txt;
            }
            return output;
        }
    }
}
