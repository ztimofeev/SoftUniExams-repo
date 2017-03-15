using System;

namespace FirstTaskMoney
{
    class Money
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var yoans = double.Parse(Console.ReadLine());
            var commision = double.Parse(Console.ReadLine());

            var bitcoinsToEuro = bitcoins * 1168 / 1.95;
            var yoansToEuro = (yoans * 0.15 * 1.76) / 1.95;
            var totalEuro = bitcoinsToEuro + yoansToEuro;
            var clearAmount = totalEuro - totalEuro * commision / 100;

            Console.WriteLine(clearAmount);
        }
    }
}
