using System;

namespace SecondTaskHarvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var wineyardArea = int.Parse(Console.ReadLine());
            var grapeHarvest = double.Parse(Console.ReadLine());
            var neededWineQuantity = int.Parse(Console.ReadLine());
            var workersCount = int.Parse(Console.ReadLine());

            var wineQuantity = wineyardArea * (grapeHarvest / 2.5) * 0.40;

            if (wineQuantity < neededWineQuantity)
            {
                var deficitWine = Math.Floor(neededWineQuantity - wineQuantity);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", deficitWine);
            }
            else
            {
                var leftLitersWine = wineQuantity - neededWineQuantity;
                var winePerWorker = leftLitersWine / workersCount;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineQuantity));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(leftLitersWine), Math.Ceiling(winePerWorker));
            }
        }
    }
}
