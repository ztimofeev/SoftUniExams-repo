using System;

namespace SixthTaskLettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            var letter1 = char.Parse(Console.ReadLine().ToLower());
            var letter2 = char.Parse(Console.ReadLine().ToLower());
            var lack = char.Parse(Console.ReadLine().ToLower());
            var counter = 0;

            for (char i = letter1; i <= letter2; i++)
            {
                for (char x = letter1; x <= letter2; x++)
                {
                    for (char y = letter1; y <= letter2; y++)
                    {
                        if (i != lack && x != lack && y != lack)
                        {
                            counter += 1;
                            Console.Write("{0}{1}{2} ", i, x, y);
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
