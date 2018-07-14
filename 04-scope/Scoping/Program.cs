using System;

namespace Scoping
{
    class Program
    {
        //class scope: called FIELDS
        string classLevelString = "I am sitting on the class level.";
        
        static void Main(string[] args)
        {
            //method level scope
            string methodLevelScope = "I am sitting at the method level.";
            Console.WriteLine("Hello World!");

            {
                //block level scope
                string blockLevelScope = "I am only visible in this block";
                Console.WriteLine(blockLevelScope);
            }
            Console.WriteLine(methodLevelScope);
           
            
        }
        void MyMethod()
        {
            Console.WriteLine(classLevelString);
        }
    }
}
