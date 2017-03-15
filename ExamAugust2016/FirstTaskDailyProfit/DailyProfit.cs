using System;

namespace FirstTaskDailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var daysProfit = double.Parse(Console.ReadLine());
            var exchangeRate = double.Parse(Console.ReadLine());

            var monthlyProfit = workingDays * daysProfit * exchangeRate;
            var anualProfit = monthlyProfit * 14.5;
            var tax = anualProfit * 0.25;
            var profit = anualProfit - tax;
            Console.WriteLine("{0:f2}", profit / 365);
        }
    }
}
