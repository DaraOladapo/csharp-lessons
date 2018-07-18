using System;

namespace ChoicesWeMake
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("What year were you born?");
            // int UserInput=int.Parse(Console.ReadLine());
            // int UserAge=DateTime.Now.Year-UserInput;
            // if(UserAge<18 && UserAge>0)
            // {
            //     Console.WriteLine("Oopsie. You're so young. Try when you're 18");
            // }
            // else if(UserAge>=18)
            // {
            //     Console.WriteLine("Yaaaay!. You made it!");
            // }
            // else
            // {
            //  Console.WriteLine("Are you from the future?");
            // }
            //Check if user input is even number and multiple of 5
            int UserInput=int.Parse(Console.ReadLine())        ;
            if(UserInput % 2 == 0){
                if(UserInput % 5 == 0){
                    Console.WriteLine("You hit a jackpot!"); 
                }
            }
        }
    }
}
