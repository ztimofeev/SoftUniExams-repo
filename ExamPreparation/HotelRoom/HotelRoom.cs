using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var overnights = int.Parse(Console.ReadLine());

            double priceAppartment = 0;
            double priceStudio = 0;

            if (month == "may" || month == "october")
            {
                if (overnights > 14)
                {
                    priceAppartment = overnights * 65.00 * 0.90;
                    priceStudio = overnights * 50 * 0.70;
                }
                else if (overnights > 7)
                {
                    priceAppartment = overnights * 65.00;
                    priceStudio = overnights * 50 * 0.95;
                }
                else
                {
                    priceAppartment = overnights * 65.00;
                    priceStudio = overnights * 50;
                }
            }
            else if (month == "june" || month == "september")
            {
                if (overnights > 14)
                {
                    priceAppartment = overnights * 68.7 * 0.90;
                    priceStudio = overnights * 75.2 * 0.80;
                }
                else
                {
                    priceAppartment = overnights * 68.7;
                    priceStudio = overnights * 75.2;
                }
            }
            else if (month == "july" || month == "august")
            {
                if (overnights > 14)
                {
                    priceAppartment = overnights * 77.00 * 0.9;
                    priceStudio = overnights * 76.00;
                }
                else
                {
                    priceAppartment = overnights * 77.00;
                    priceStudio = overnights * 76.00;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", priceAppartment);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
        }
    }
}
