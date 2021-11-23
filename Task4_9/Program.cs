using System;

namespace Task4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete = new Athlete("Ivanov", 10, 4);
            Console.WriteLine(athlete);
            athlete.CountOfCompetitions = 12;
            Console.WriteLine(athlete);
            athlete.SumOfPlaces = 5;
            Console.WriteLine(athlete);

            ChildAthlete childAthlete = new ChildAthlete("Petrov", 10, 3, true);
            Console.WriteLine(childAthlete);
            childAthlete.CountOfCompetitions = 12;
            Console.WriteLine(childAthlete);
            childAthlete.WasFirstPlace = false;
            Console.WriteLine(childAthlete);
            childAthlete.SumOfPlaces = 5;
            Console.WriteLine(childAthlete);
        }
    }
}
