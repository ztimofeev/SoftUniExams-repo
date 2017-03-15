using System;

namespace FirstTaskTilesReparing
{
    class TilesReparing
    {
        static void Main(string[] args)
        {
            var playgroundSide = int.Parse(Console.ReadLine());
            var tailWidth = double.Parse(Console.ReadLine());
            var tailHeight = double.Parse(Console.ReadLine());
            var benchWidth = int.Parse(Console.ReadLine());
            var benchHeight = int.Parse(Console.ReadLine());

            var playgrounArea = playgroundSide * playgroundSide - benchWidth * benchHeight;
            var tailArea = tailWidth * tailHeight;
            var countTails = playgrounArea / tailArea;
            Console.WriteLine(countTails);
            Console.WriteLine(countTails * 0.2);
        }
    }
}
