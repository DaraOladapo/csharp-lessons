using System;

namespace HandlingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            int someInt= 255;
            double Double007 = 52.5;
            string someString = "Holla!";
            long someLongi = 645467843548495;
            var someIntType= someInt.GetType();
            var Double007Type = Double007.GetType();
            var someStringType = someString.GetType();
            var someLongiType = someLongi.GetType();
            Console.WriteLine($"{someInt} is of data type {someIntType}");
            Console.WriteLine($"{Double007} is of data type {Double007Type}");
            Console.WriteLine($"{someString} is of data type {someStringType}");
            Console.WriteLine($"{someLongi} is of data type {someLongiType}");

            Console.ReadLine();
        }
    }
}
