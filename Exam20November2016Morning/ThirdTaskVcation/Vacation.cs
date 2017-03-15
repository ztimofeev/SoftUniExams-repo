using System;

namespace ThirdTaskVcation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var countAdult = int.Parse(Console.ReadLine());
            var countChild = int.Parse(Console.ReadLine());
            var overnights = int.Parse(Console.ReadLine());
            var transportKind = Console.ReadLine().ToLower();

            double ticketPrice = 0;


            if (transportKind == "train")
            {
                ticketPrice = countAdult * 24.99 + countChild * 14.99;
                if (countAdult + countChild >= 50)
                {
                    ticketPrice = ticketPrice * 0.5;
                }
            }
            else if (transportKind == "bus")
            {
                ticketPrice = countAdult * 32.50 + countChild * 28.50;
            }
            else if (transportKind == "boat")
            {
                ticketPrice = countAdult * 42.99 + countChild * 39.99;
            }
            else if (transportKind == "airplane")
            {
                ticketPrice = countAdult * 70 + countChild * 50.00;
            }

            var totalPrice = (overnights * 82.99 + ticketPrice * 2) * 1.10;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
