using System;

namespace ThirthTaskTrip
{
    class Trip
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            if (season == "summer")
            {
                if (budget <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", budget * 0.30);
                }
                else if (budget <= 1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", budget * 0.40);
                }
                else
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.90);
                }
            }

            if (season == "winter")
            {
                if (budget <= 100)
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.70);
                }
                else if (budget <= 1000)
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.80);
                }
                else
                {
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.90);
                }
            }
        }
    }
}
