using System;

namespace SecondTaskPoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {

            var poolVolume = int.Parse(Console.ReadLine());
            var firstPipeFlow = int.Parse(Console.ReadLine());
            var secondPipeFlow = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var firstPipeVolume = firstPipeFlow * hours;
            var secondPipeVolume = secondPipeFlow * hours;
            var totalFlowVolume = firstPipeVolume + secondPipeVolume;

            if (totalFlowVolume > poolVolume)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, totalFlowVolume - poolVolume);
            }
            else
            {
                var poolFulness = totalFlowVolume / poolVolume * 100;
                var firstPipeShare = (firstPipeVolume / totalFlowVolume) * 100;
                var secondPipeShare = (secondPipeVolume / totalFlowVolume) * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int)poolFulness, (int)firstPipeShare, (int)secondPipeShare);
            }
        }
    }
}
