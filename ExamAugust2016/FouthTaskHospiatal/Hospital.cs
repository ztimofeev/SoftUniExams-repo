using System;

namespace FouthTaskHospiatal
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());

            var doctors = 7;
            var treated = 0;
            var untreated = 0;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        doctors += 1;
                    }
                }

                var patients = int.Parse(Console.ReadLine());
                if (patients > doctors)
                {
                    untreated += patients - doctors;
                    treated += doctors;
                }
                else
                {
                    treated += patients;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
