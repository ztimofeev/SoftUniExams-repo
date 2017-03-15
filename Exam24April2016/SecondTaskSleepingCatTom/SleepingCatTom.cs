using System;

namespace SecondTaskSleepingCatTom
{
    class SleepingCatTom
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());

            var totalPlayTime = (365 - holidays) * 63 + holidays * 127;
            var diff = Math.Abs(totalPlayTime - 30000);
            var hours = diff / 60;
            var minutes = diff % 60;

            if (totalPlayTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
