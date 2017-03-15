using System;

namespace SixthTaskNumbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstDigit = n / 100;
            var secondDigit = (n / 10) % 10;
            var thirdDigit = n % 10;

            var rows = firstDigit + secondDigit;
            var cols = firstDigit + thirdDigit;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - secondDigit;
                    }
                    else
                    {
                        n = n + thirdDigit;
                    }
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
