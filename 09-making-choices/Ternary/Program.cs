using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We want to check if an input value is an even number\nEnter an integer value below.");
            string OutputMessage;
            int InputValue=int.Parse(Console.ReadLine());
            
            //Ternart Operator =?:
            OutputMessage=
            (InputValue%2==0)?
            $"{InputValue} is an even number.":
            $"{InputValue} is an odd number.";

            Console.WriteLine(OutputMessage);

        }
    }
}
