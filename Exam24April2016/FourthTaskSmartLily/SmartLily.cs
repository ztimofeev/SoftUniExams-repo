using System;

namespace FourthTaskSmartLily
{
    class SmartLily
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washmachinePrice = double.Parse(Console.ReadLine());
            var toyPrice = double.Parse(Console.ReadLine());

            double savedMoney = 0;
            int toysCount = 0;
            int count = 1;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += (10 * count) - 1;
                    count++;
                }
                else
                {
                    toysCount += 1;
                }
            }

            double profitFromToys = toysCount * toyPrice;
            double totalMoney = profitFromToys + savedMoney;

            if (totalMoney >= washmachinePrice)
            {
                double diff = totalMoney - washmachinePrice;
                Console.WriteLine("Yes! {0:F2}", diff);
            }
            else
            {
                double diff = washmachinePrice - totalMoney;
                Console.WriteLine("No! {0:F2}", diff);
            }
        }
    }
}
