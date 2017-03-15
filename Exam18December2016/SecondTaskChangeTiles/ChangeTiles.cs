using System;

namespace SecondTaskChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var floorWidth = double.Parse(Console.ReadLine());
            var floorHeight = double.Parse(Console.ReadLine());
            var tileSide = double.Parse(Console.ReadLine());
            var tailHeight = double.Parse(Console.ReadLine());
            var tailPrice = double.Parse(Console.ReadLine());
            var masterPrice = double.Parse(Console.ReadLine());

            var floorArea = floorWidth * floorHeight;
            var tailArea = tileSide * tailHeight / 2;
            var tailCount = Math.Ceiling(floorArea / tailArea) + 5;
            var totalPrice = tailCount * tailPrice + masterPrice;
            var difference = Math.Abs(money - totalPrice);

            if (money >= totalPrice)
            {
                Console.WriteLine("{0:f2} lv left.", difference);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", difference);
            }
        }
    }
}
