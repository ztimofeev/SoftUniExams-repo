using System;

namespace FourthTaskGrades
{
    class Grades
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            var excellent = 0;
            var verywell = 0;
            var middle = 0;
            var fail = 0;
            var sum = 0.0;

            for (int i = 0; i < number; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                sum += grade;
                if (grade < 3.00)
                {
                    fail += 1;
                }
                else if (grade < 4.00)
                {
                    middle += 1;
                }
                else if (grade < 5.00)
                {
                    verywell += 1;
                }
                else
                {
                    excellent += 1;
                }
            }

            var average = sum / number;

            Console.WriteLine("Top students: {0:f2}%", excellent / number * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", verywell / number * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", middle / number * 100);
            Console.WriteLine("Fail: {0:f2}%", fail / number * 100);
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}
