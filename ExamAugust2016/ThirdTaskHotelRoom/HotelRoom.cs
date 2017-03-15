using System;

namespace ThirdTaskHotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {

            var month = Console.ReadLine().ToLower();
            var days = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceAppartment = 0;


            if (month == "may" || month == "october")
            {
                if (days > 7 && days <= 14)
                {
                    priceStudio = 50 - (50 * 0.05);
                    priceAppartment = 65.00;
                }
                else if (days > 14)
                {
                    priceStudio = 50 - (50 * 0.30);
                    priceAppartment = 65 - (65 * 0.10);
                }
                else
                {
                    priceStudio = 50.00;
                    priceAppartment = 65.00;
                }
            }
            else if (month == "june" || month == "september")
            {
                if (days > 14)
                {
                    priceStudio = 75.20 - (75.20 * 0.20);
                    priceAppartment = 68.70 - (68.70 * 0.10);
                }
                else
                {
                    priceStudio = 75.20;
                    priceAppartment = 68.70;
                }
            }
            else if (month == "july" || month == "august")
            {
                priceStudio = 76.00;
                if (days > 14)
                {
                    priceAppartment = 77.00 - (77.00 * 0.10);
                }
                else
                {
                    priceAppartment = 77.00;
                }
            }

            double totalPriceStudio = days * priceStudio;
            double totalPriceAppartment = days * priceAppartment;

            Console.WriteLine("Apartment: {0:F2} lv.", totalPriceAppartment);
            Console.WriteLine("Studio: {0:F2} lv.", totalPriceStudio);
        }
    }
}
