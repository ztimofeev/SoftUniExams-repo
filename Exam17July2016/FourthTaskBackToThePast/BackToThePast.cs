using System;

namespace FourthTaskBackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            var heritage = double.Parse(Console.ReadLine());
            var finalYear = int.Parse(Console.ReadLine());
            var spendMoney = 0;
            var age = 18;

            for (int i = 1800; i <= finalYear; i++)
            {
                if (age % 2 == 0)
                {
                    spendMoney += 12000;
                }
                else
                {
                    spendMoney += (12000 + 50 * age);
                }
                age += 1;
            }

            if (heritage >= spendMoney)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", heritage - spendMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", spendMoney - heritage);
            }
        }
    }
}
