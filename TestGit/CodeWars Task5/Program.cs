using System;

namespace CodeWars_Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            Lasagna lasagna = new();
            int timeCook = lasagna.ElapsedTimeInMinutes(4, 8);
            Console.WriteLine(timeCook);
        }
        class Lasagna
        {
            public object lasagna;
            public int ExpectedMinutesInOven() => 40;
            public int RemainingMinutesInOven(int min) => 40 - min;
            public int PreparationTimeInMinutes(int layers) => layers * 2;
            public int ElapsedTimeInMinutes(int layers, int min) => min + PreparationTimeInMinutes(layers);
        }
    }
}
