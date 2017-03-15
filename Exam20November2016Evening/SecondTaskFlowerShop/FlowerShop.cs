using System;

namespace SecondTaskFlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            var magnolia = int.Parse(Console.ReadLine());
            var hyacinth = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cactus = int.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());

            var orderAmount = (magnolia * 3.25 + hyacinth * 4.00 + roses * 3.50 + cactus * 8.00) * 0.95;
            var diff = Math.Abs(orderAmount - presentPrice);

            if (orderAmount >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(diff));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(diff));
            }
        }
    }
}
