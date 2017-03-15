using System;

namespace ThirdTaskNumberOperatins
{
    class NumberOperations
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var action = char.Parse(Console.ReadLine());
            double result = 0;
            var type = "odd";

            if (action == '+')
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    type = "even";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, action, n2, result, type);
            }
            else if (action == '-')
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    type = "even";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, action, n2, result, type);
            }
            else if (action == '*')
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    type = "even";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, action, n2, result, type);
            }
            else if (action == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 / (double)n2;
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
                }
            }
            else if (action == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
                }
            }
        }
    }
}
