using System;

namespace SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We want to use switch cases\nEnter a value");
            int inputVal=int.Parse(Console.ReadLine());
            switch (inputVal)
            {
             case 1:
                Console.WriteLine("Your input is 1");
             break;
             case 2:
            Console.WriteLine("Your input is 2");
             break;
             case 3:
            Console.WriteLine("Your input is 3");
             break;
            default:
            Console.WriteLine("Your input cannot be verified.");
             break;   
            }
        }
    }
}
