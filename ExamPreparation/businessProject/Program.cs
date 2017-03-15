using System;

namespace businessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var employees = int.Parse(Console.ReadLine());

            var totalTime = (days - days * 0.1) * 8 ;
            var result = Math.Floor(totalTime + days * 2 * employees);

            if (result >= hours)
            {
                result = result - hours;
                Console.WriteLine("Yes!{0} hours left.", result);
            }
            else
            {
                result = hours - result;
                Console.WriteLine("Not enough time!{0} hours needed.", result);
            }
        }
    }
}
