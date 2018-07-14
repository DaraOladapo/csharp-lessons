using System;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstValue = 30, secondValue = 15;
            //divisions
            //int dividedValue = firstValue / secondValue;
            //int anotherDividedValue = secondValue / firstValue;
            //Console.WriteLine($"{firstValue}/{secondValue}={dividedValue}");
            //Console.WriteLine($"{secondValue}/{firstValue}={anotherDividedValue}");
            //we declared int. Let's switch things a bit.
            int firstValue = 30, secondValue = 15;
            //method 1
            double castedDivided = (double)secondValue / (double)firstValue;
            Console.WriteLine($"{secondValue}/{firstValue}={castedDivided}");//method 1
            //method 2
            double parsedDivided = double.Parse(secondValue.ToString()) / double.Parse(firstValue.ToString());
            Console.WriteLine($"{secondValue}/{firstValue}={parsedDivided}");
        }
    }
}
