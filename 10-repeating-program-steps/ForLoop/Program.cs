using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AllStudents={"James","John", "Julian","Joseph"};
            for(int i=0;i<AllStudents.Length;i++){
                Console.WriteLine(AllStudents[i]);
            }


            int[] someValues={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            for(int i=1;i<=someValues.Length;i+=2){
                Console.WriteLine(someValues[i]);
            }
        }
    }
}
