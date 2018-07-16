using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Juma");
            names.Add("Rima");
            Console.WriteLine("Item at index 0");
            Console.WriteLine(names[0]);
            Console.WriteLine("Item at index 1");
            Console.WriteLine(names[1]);
            //remove
            names.Remove("Juma");
            //add new
            names.Add("Rena");
            Console.WriteLine("New item at index 0");
            Console.WriteLine(names[0]); 
            Console.WriteLine("New item at index 1");
            Console.WriteLine(names[1]);
            //clear items
            names.Clear();
            string[] stringArray={"Zuam", "Zing","Zuga","Rino"};
            names.AddRange(stringArray);
            Console.WriteLine("New Items");
            foreach (var name in names)
	        {
                Console.WriteLine(name);
	        }
        }
    }
}
