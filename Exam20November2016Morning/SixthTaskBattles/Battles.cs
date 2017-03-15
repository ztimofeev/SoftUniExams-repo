using System;

namespace SixthTaskBattles
{
    class Battles
    {
        static void Main(string[] args)
        {
            var firstPlayerPoks = int.Parse(Console.ReadLine());
            var secondPlayerPoks = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());

            var battlesCounter = 1;

            for (int i = 1; i <= firstPlayerPoks; i++)
            {
                for (int j = 1; j <= secondPlayerPoks; j++)
                {
                    if (battlesCounter <= maxBattles)
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                        battlesCounter += 1;
                    }
                }
            }
        }
    }
}
