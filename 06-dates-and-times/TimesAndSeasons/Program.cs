using System;

namespace TimesAndSeasons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Today's full date is {DateTime.Now}");
            Console.WriteLine($"Today's long date is {DateTime.Now.ToLongDateString()}");
            Console.WriteLine($"Today's short date is {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"The long time is {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"The time is {DateTime.Now.ToShortTimeString()}");

        }
    }
}
