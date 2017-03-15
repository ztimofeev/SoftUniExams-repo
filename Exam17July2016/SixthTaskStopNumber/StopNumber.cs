using System;

namespace SixthTaskStopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == stop)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
