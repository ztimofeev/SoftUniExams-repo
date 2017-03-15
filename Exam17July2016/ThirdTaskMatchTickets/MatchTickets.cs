using System;

namespace ThirdTaskMatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var ticketCategorty = Console.ReadLine().ToLower();
            var countPeople = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double restMoney = 0;

            if (ticketCategorty == "vip")
            {
                ticketPrice = 499.99;
            }
            else if (ticketCategorty == "normal")
            {
                ticketPrice = 249.99;
            }
            else
            {
                Console.WriteLine("Wrong tiicket category!!!");
            }

            if (countPeople < 5)
            {
                restMoney = budget * 0.25;
            }
            else if (countPeople < 10)
            {
                restMoney = budget * 0.40;
            }
            else if (countPeople < 25)
            {
                restMoney = budget * 0.50;
            }
            else if (countPeople < 50)
            {
                restMoney = budget * 0.60;
            }
            else
            {
                restMoney = budget * 0.75;
            }

            double budgetForTickets = countPeople * ticketPrice;

            if (restMoney >= budgetForTickets)
            {
                double result = restMoney - budgetForTickets;
                Console.WriteLine("Yes! You have {0:F2} leva left.", result);
            }
            else
            {
                double result = budgetForTickets - restMoney;
                Console.WriteLine("Not enough money! You need {0:F2} leva.", result);
            }
        }
    }
}
