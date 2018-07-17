using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            int intValue;

            //assignment
            intValue=225;
            Console.WriteLine($"intValue={intValue}");

            //declare and assign
            double doubleValue=52.65;
            Console.WriteLine($"doubleValue={doubleValue}");

            //assigning another value
            doubleValue=66.5;
            Console.WriteLine($"doubleValue's new value  = {doubleValue}");
        }
    }
}
