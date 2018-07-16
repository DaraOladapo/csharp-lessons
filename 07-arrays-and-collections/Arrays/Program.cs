using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] intArray=new int[5];
           System.Console.WriteLine($"intArray has a length of {intArray.Length}");
           intArray[0]=12;
           intArray[1]=11;
           intArray[2]=1;
           intArray[4]=85;
           Console.WriteLine(intArray[3]);
           Console.WriteLine(intArray[4]);

            string[] someStringArray=new string[5];
            someStringArray[4]="Hello string array item 4";
            Console.WriteLine(someStringArray[4]);
            Console.WriteLine(someStringArray[3]);

            string stringToSplit="ABCDEF";
            Console.WriteLine(stringToSplit[4]);
            string spacedString="A B C D E F";
            char[] arraySplitter={' '};
            string[] splittedStringV1=spacedString.Split(arraySplitter);
            string[] splittedStringV2=spacedString.Split(arraySplitter,StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(splittedStringV1[2]);
            Console.WriteLine(splittedStringV2[5]);
        }
    }
}
