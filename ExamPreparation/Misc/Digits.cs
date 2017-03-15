using System;

namespace Misc
{
    class Digits
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var firstDigit = num / 100;
            var secondDigit = (num / 10) % 10;
            var tirthDigit = num % 10;

            for (int i = 0; i < (firstDigit + secondDigit); i++)
            {
                for (int j = 0; j < (firstDigit + tirthDigit); j++)
                {
                    if (num % 5 == 0)
                    {
                        num = num - firstDigit;
                    }
                    else if (num % 3 == 0)
                    {
                        num = num - secondDigit;
                    }
                    else
                    {
                        num = num + tirthDigit;
                    }
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}
