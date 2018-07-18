using System;

namespace Methodologies
{
    class Program
    {
        static void Main(string[] args)
        { 
          int FirstVal=int.Parse(Console.ReadLine()), SecondVal=int.Parse(Console.ReadLine());
           int AddedValue=AddValues(FirstVal,SecondVal);
           Console.WriteLine(AddedValue);
        }

        static int AddValues(int firstVal, int secondVal){
        return firstVal+secondVal;
        }

       
    }
}
