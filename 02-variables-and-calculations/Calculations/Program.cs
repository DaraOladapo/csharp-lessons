using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //on some int
            int firstValue = 30, secondValue = 15;
            //addition
            int addedValue = firstValue + secondValue;
            Console.WriteLine($"{firstValue}+{secondValue}={addedValue}");
            //substractions
            int subtractedValue = secondValue - firstValue;
            int secondSubtractedValue = firstValue - secondValue;
            Console.WriteLine($"{secondValue}-{firstValue}={subtractedValue}");
            Console.WriteLine($"{firstValue}-{secondValue}={secondSubtractedValue}");
            //multiplications
            int multipliedValue = firstValue * secondValue;
            Console.WriteLine($"{firstValue}{secondValue}={multipliedValue}");
            //divisions
            int dividedValue = firstValue / secondValue;
            int anotherDividedValue = secondValue / firstValue;
            Console.WriteLine($"{firstValue}/{secondValue}={dividedValue}");
            Console.WriteLine($"{secondValue}/{firstValue}={anotherDividedValue}");
        }
    }
}
