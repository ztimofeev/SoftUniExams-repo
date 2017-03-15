using System;

namespace FirstTaskFishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            var mackerelPrice = double.Parse(Console.ReadLine());
            var spratPrice = double.Parse(Console.ReadLine());
            var kgBonito = double.Parse(Console.ReadLine());
            var kgScad = double.Parse(Console.ReadLine());
            var kgClams = int.Parse(Console.ReadLine());

            var totalPrice = kgClams * 7.50 + kgScad * (spratPrice * 1.80) + kgBonito * (mackerelPrice * 1.60);
            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
