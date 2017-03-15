using System;

namespace SixthTaskSpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                for (int x = 1; x < 10; x++)
                {
                    for (int y = 1; y < 10; y++)
                    {
                        for (int z = 1; z < 10; z++)
                        {
                            if (n % i == 0 && n % x == 0 && n % y == 0 && n % z == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, x, y, z);
                            }
                        }
                    }
                }
            }
        }
    }
}
