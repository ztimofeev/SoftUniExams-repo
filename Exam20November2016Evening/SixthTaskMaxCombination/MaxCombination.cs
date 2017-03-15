using System;

namespace SixthTaskMaxCombination
{
    class MaxCombination
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var lastNumber = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());
            var countCombinations = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                for (int j = firstNumber; j <= lastNumber; j++)
                {
                    Console.Write("<{0}-{1}>", i, j);
                    countCombinations += 1;
                    if (countCombinations == maxCombinations)
                    {
                        return;
                    }
                }
            }
        }
    }
}
