using System;

namespace FirstTaskVegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            var vegetablesPrice = double.Parse(Console.ReadLine());
            var fruitsPrice = double.Parse(Console.ReadLine());
            var vegetablesHarvest = double.Parse(Console.ReadLine());
            var fruitsHarvest = double.Parse(Console.ReadLine());

            var profit = (vegetablesHarvest * vegetablesPrice + fruitsHarvest * fruitsPrice) / 1.94;
            Console.WriteLine(profit);
        }
    }
}
