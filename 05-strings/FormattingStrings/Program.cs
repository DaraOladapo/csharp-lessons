using System;

namespace FormattingStrings
{
    public class SaleItem
    {
        public string Name
        { get; set; }

        public decimal Price
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var item = new SaleItem { Name = "Shoes", Price = 19.95m };
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");


            //ToString()
            int someInt = 45;
            string someString = someInt.ToString();
            Console.WriteLine(someString);

            string someSuperString = "I am some string with some string and some other string.";
            //ToLower()
            Console.WriteLine(someSuperString.ToLower());
            //ToLower()
            Console.WriteLine(someSuperString.ToUpper());

            string Name = "John Smith";
            var StartsWith = Name.StartsWith("J");
            Console.WriteLine(StartsWith);
            var Contains = Name.Contains("oh");
            Console.WriteLine(Contains);
            var ContainsUpper = Name.Contains("Oh");
            Console.WriteLine(ContainsUpper);
        }
    }

}
