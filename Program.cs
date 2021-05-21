using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentYear = 2080;
            double earthAgeDays = 365.25;
            double earthAgeSec = 31557600;
            double newAgeSec = 631154000;
            int time = 60*60*24;
            double result = (newAgeSec*earthAgeDays)/earthAgeSec;
            double result1 = result/earthAgeDays;
            Console.WriteLine($"Earth Age: {result1} Earth-years old");
        }
    }
}
