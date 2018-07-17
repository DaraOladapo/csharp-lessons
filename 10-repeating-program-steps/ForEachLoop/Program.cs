using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AllStudents={"James","John", "Julian","Joseph"};
            foreach (var item in AllStudents)
            {
                Console.WriteLine(item);
            }


            int[] someValues={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            foreach (var item in someValues)
            {
                Console.WriteLine(item);
            }
        }
    }
}
