using System;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var dayProfit = double.Parse(Console.ReadLine());
            var currencyRate = double.Parse(Console.ReadLine());

            var anualProfit = workingDays * dayProfit * 12;
            var bonus = workingDays * dayProfit * 2.5;
            var profit = (anualProfit + bonus - (anualProfit + bonus) * 0.25) * currencyRate;
            Console.WriteLine("{0:f2}", profit / 365);
        }
    }
}
