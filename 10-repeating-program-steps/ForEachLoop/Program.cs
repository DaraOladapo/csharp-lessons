using System;
using System.Collections.Generic;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Students={"James","John", "Julian","Joseph"};
            List<string> AllStudents=new List<string>();
            AllStudents.AddRange(Students);
            // foreach (var item in AllStudents)
            // {
            //     Console.WriteLine(item);
            // }

            var ItemToFind=AllStudents.Find(opt=>opt=="John");
            Console.WriteLine(ItemToFind);

            var ItemsToFind=AllStudents.FindAll(opt=>opt.ToLower().Contains("O".ToLower()));
        foreach (var item in ItemsToFind){
            Console.WriteLine(item);
        }

            int[] someValues={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            // foreach (var item in someValues)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}
