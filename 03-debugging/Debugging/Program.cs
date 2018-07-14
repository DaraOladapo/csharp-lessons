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
            //method 1: Casting
            double castedDivided = (double)secondValue / (double)firstValue;
            Console.WriteLine($"{secondValue}/{firstValue}={castedDivided}");
            //method 2:Conversion
            double convertDivided = Convert.ToDouble(secondValue) / Convert.ToDouble(firstValue);
            Console.WriteLine($"{secondValue}/{firstValue}={convertDivided}");
            //method 3:Parsing
            double parsedDivided = double.Parse(secondValue.ToString()) / double.Parse(firstValue.ToString());
            Console.WriteLine($"{secondValue}/{firstValue}={parsedDivided}");

            //accept Values
            var InputValue = Console.ReadLine();
            Console.WriteLine($"Your input was {InputValue} of datatype {InputValue.GetType()}");
        }
    }
}
