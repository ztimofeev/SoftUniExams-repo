using System;

namespace FirstTaskDistance
{
    class Distance
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var timeFirst = int.Parse(Console.ReadLine());
            var timeSecond = int.Parse(Console.ReadLine());
            var timeToEnd = int.Parse(Console.ReadLine());

            var speedUp = speed * 1.10;
            var distStart = timeFirst / 60.0 * speed;
            var distSpeedUp = timeSecond / 60.0 * speedUp;
            var distSpeedDown = timeToEnd / 60.0 * speedUp * 0.95;
            var distance = distStart + distSpeedUp + distSpeedDown;

            Console.WriteLine("{0:f2}", distance);
        }
    }
}
