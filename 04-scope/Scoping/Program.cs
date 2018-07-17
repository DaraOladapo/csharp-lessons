using System;

namespace Scoping
{
    class Program
    {
        //class scope: called FIELDS
        static string SittingRoom = "Sitting Room";
        static string Garage = "Garage";
        static void Parents()
        {
            string MasterBedroom = "Master Bedroom", Vault = "The Vault";
            Console.WriteLine($"{SittingRoom},{Garage},{MasterBedroom} and {Vault}");
        }
        static void Mother()
        {
            Parents();
            string Kitchen = "The Kitchen";
            Console.Write($"I can access {Kitchen}, also");
        }
       static  void Children()
        {
            Console.WriteLine($"{SittingRoom},{Garage} and our room");
        }
        static void FirstBorn()
        {
            Parents();
        }
   static void Maid()
        {
        Console.WriteLine($"I can only access where oga madam tells me plus {SittingRoom} and {Garage}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Maid");
            Maid();
            Console.WriteLine("Mother");
            Mother();
            Console.WriteLine("First Born");
            FirstBorn();
            Console.WriteLine("Children");
            Children();
        }
        static void MyMethod()
        {
            
        }
    }

    
}
