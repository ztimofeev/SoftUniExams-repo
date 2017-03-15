using System;

namespace SecondTaskPets
{
    class Pats
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var dogRation = double.Parse(Console.ReadLine());
            var catRation = double.Parse(Console.ReadLine());
            var turtleRation = double.Parse(Console.ReadLine());

            var spentFood = days * (dogRation + catRation + turtleRation / 1000.00);

            if (food >= spentFood)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - spentFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(spentFood - food));
            }
        }
    }
}
