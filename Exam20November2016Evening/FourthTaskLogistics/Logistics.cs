using System;

namespace FourthTaskLogistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            var numberFreights = int.Parse(Console.ReadLine());

            var cargoSmall = 0;
            var cargoMiddle = 0;
            var cargoBig = 0;
            var totalWeight = 0;
            var weightSmall = 0;
            var weightMiddle = 0;
            var weightBig = 0;

            for (int i = 0; i < numberFreights; i++)
            {
                var fright = int.Parse(Console.ReadLine());
                totalWeight += fright;

                if (fright <= 3)
                {
                    weightSmall += fright;
                    cargoSmall += fright * 200;
                }
                else if (fright <= 11)
                {
                    weightMiddle += fright;
                    cargoMiddle += fright * 175;
                }
                else
                {
                    weightBig += fright;
                    cargoBig += fright * 120;
                }
            }
            var average = (cargoSmall + cargoMiddle + cargoBig) / (double)totalWeight;

            Console.WriteLine("{0:f2}", average);
            Console.WriteLine("{0:f2}%", (double)weightSmall / totalWeight * 100);
            Console.WriteLine("{0:f2}%", (double)weightMiddle / totalWeight * 100);
            Console.WriteLine("{0:f2}%", (double)weightBig / totalWeight * 100);
        }
    }
}
