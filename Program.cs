using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            double earthAgeDays = 365.25;
            double earthAgeSec = 31557600;
            double newAgeSec = 631154000;


            double result = (newAgeSec*earthAgeDays)/earthAgeSec;
            double result1 = result/earthAgeDays;
            var result3 = Math.Floor(result1);
            
            Console.WriteLine($"Earth Age: {result3} Earth-years old");
        }
    }
}
