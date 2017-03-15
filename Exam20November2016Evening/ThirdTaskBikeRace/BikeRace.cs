using System;

namespace ThirdTaskBikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            var numJuniors = int.Parse(Console.ReadLine());
            var numSeniors = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine().ToLower();

            double taxes = 0;

            if (trace == "trail")
            {
                taxes = numJuniors * 5.50 + numSeniors * 7.00;
            }
            else if (trace == "cross-country")
            {
                taxes = numJuniors * 8.00 + numSeniors * 9.50;
                if (numJuniors + numSeniors >= 50)
                {
                    taxes = taxes * 0.75;
                }
            }
            else if (trace == "downhill")
            {
                taxes = numJuniors * 12.25 + numSeniors * 13.75;
            }
            else if (trace == "road")
            {
                taxes = numJuniors * 20.00 + numSeniors * 21.50;
            }

            var total = taxes * 0.95;
            Console.WriteLine("{0:f2}", total);
        }
    }
}
