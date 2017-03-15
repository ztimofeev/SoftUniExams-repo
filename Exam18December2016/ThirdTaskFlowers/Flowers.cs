
using System;

namespace ThirdTaskFlowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            var chrys = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var isHoliday = Console.ReadLine().ToLower();

            var flowerCount = chrys + roses + tulips;
            double totalPrice = 0;
            double discount = 1.0;
            double quantityDiscount = 1.0;

            if (season == "spring" || season == "summer")
            {
                totalPrice = chrys * 2.00 + roses * 4.10 + tulips * 2.50;
                if (season == "spring" && tulips > 7)
                {
                    discount = 0.95;
                }
            }
            else if (season == "autumn" || season == "winter")
            {
                totalPrice = chrys * 3.75 + roses * 4.50 + tulips * 4.15;

                if (season == "winter" && roses >= 10)
                {
                    discount = 0.90;
                }
            }

            if (isHoliday == "y")
            {
                totalPrice *= 1.15;
            }

            if (flowerCount > 20)
            {
                quantityDiscount = 0.80;
            }

            var finalAmount = totalPrice * discount * quantityDiscount + 2;
            Console.WriteLine("{0:f2}", finalAmount);
        }
    }
}
