using System;

namespace FirstTaskHousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kichen = double.Parse(Console.ReadLine());
            var priceSqMeter = double.Parse(Console.ReadLine());

            var bathRoom = smallestRoom / 2;
            var secondRoom = smallestRoom * 1.10;
            var thirdRoom = secondRoom * 1.10;
            var totalArea = (kichen + smallestRoom + secondRoom + thirdRoom + bathRoom) * 1.05;
            Console.WriteLine("{0:f2}", totalArea * priceSqMeter);
        }
    }
}
