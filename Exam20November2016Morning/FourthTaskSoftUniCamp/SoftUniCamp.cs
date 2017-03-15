using System;

namespace FourthTaskSoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            var groupsCount = int.Parse(Console.ReadLine());

            double totalCountPeople = 0.0;
            var countPeopleWithCar = 0;
            var countPeopleWithMicrobus = 0;
            var countPeopleWithSmallBus = 0;
            var countPeopleWithBus = 0;
            var countPeopleWithTrain = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                var participants = int.Parse(Console.ReadLine());
                totalCountPeople += participants;
                if (participants <= 5)
                {
                    countPeopleWithCar += participants;
                }
                else if (participants <= 12)
                {
                    countPeopleWithMicrobus += participants;
                }
                else if (participants <= 25)
                {
                    countPeopleWithSmallBus += participants;
                }
                else if (participants <= 40)
                {
                    countPeopleWithBus += participants;
                }
                else
                {
                    countPeopleWithTrain += participants;
                }
            }
            Console.WriteLine("{0:f2}%", countPeopleWithCar / totalCountPeople * 100);
            Console.WriteLine("{0:f2}%", countPeopleWithMicrobus / totalCountPeople * 100);
            Console.WriteLine("{0:f2}%", countPeopleWithSmallBus / totalCountPeople * 100);
            Console.WriteLine("{0:f2}%", countPeopleWithBus / totalCountPeople * 100);
            Console.WriteLine("{0:f2}%", countPeopleWithTrain / totalCountPeople * 100);
        }
    }
}
