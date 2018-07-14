using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //on some int
            int firstValue = 25, secondValue = 15;
            int addedValue = firstValue + secondValue;
            int subtractedValue = secondValue - firstValue;
            int secondSubtractedValue = firstValue - secondValue;
            //addition
            Console.WriteLine($"{firstValue}+{secondValue}={addedValue}");
            //substractions
            Console.WriteLine($"{secondValue}-{firstValue}={subtractedValue}");
            Console.WriteLine($"{firstValue}-{secondValue}={secondSubtractedValue}");
        }
    }
}
