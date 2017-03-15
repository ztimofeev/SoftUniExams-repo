using System;

namespace FourthTaskDivision
{
    class Division
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < number; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    count1 += 1;
                }
                if (currentNumber % 3 == 0)
                {
                    count2 += 1;
                }
                if (currentNumber % 4 == 0)
                {
                    count3 += 1;
                }
            }
            double percentage1 = (double)count1 / number * 100;
            double percentage2 = (double)count2 / number * 100;
            double percentage3 = (double)count3 / number * 100;

            Console.WriteLine("{0:F2}%", percentage1);
            Console.WriteLine("{0:F2}%", percentage2);
            Console.WriteLine("{0:F2}%", percentage3);
        }
    }
}
