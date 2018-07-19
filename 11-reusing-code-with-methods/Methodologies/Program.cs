using System;

namespace Methodologies
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstIntVal = 12, SecondIntVal = 32;
            double FirstDoubleVal = 2.5, SecondDoubleVal = 5.2;
            Console.WriteLine($"{AddValues(FirstIntVal,SecondIntVal)}");
            Console.WriteLine($"{AddValues(FirstDoubleVal, SecondDoubleVal)}");
            Console.WriteLine($"{AddValues(FirstDoubleVal, SecondIntVal)}");
        }
        static int AddValues(int firstVal, int secondVal)
        {
            return firstVal + secondVal;
        }
        static double AddValues(double firstVal, double secondVal)
        {
            return firstVal + secondVal;
        }
        static double AddValues(double firstVal, int secondVal)
        {
            return firstVal + secondVal;
        }
    }
}
