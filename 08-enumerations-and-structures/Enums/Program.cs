using System;

namespace Enums
{
    class Program
    {
        enum EmployeeLevel
        {
            Starter,Junior,MidLevel,Senior,TopManagement,Chairman
        }
        enum AccountType{
            KidStarter, Savings, Student
        }
        class AccountOwner{
            public string FullName { get; set; }
            public AccountType customerAccountType { get; set; }
            public string BVN { get; set; }
        }
        static AccountOwner customer;
        static void Main(string[] args){
         Console.WriteLine($"My level as an employee is {EmployeeLevel.Senior}");
         customer = new AccountOwner();
         //customer.CustomerAccountType="Current";
         //customer.CustomerAccountType=AccountType.Current.ToString();
        Console.WriteLine("What is your name?");
        customer.FullName=Console.ReadLine();
        Console.WriteLine("What kind of account do you want?");
        Console.WriteLine("1 for KidStarter, 2 for savings, 3 for Student");
        string userInput=Console.ReadLine();
       
        

      if(!IsInputValid(userInput)){
        Console.WriteLine("Invalid input, try again.");
        userInput = Console.ReadLine();
      }  
      else{
        Console.WriteLine($"Welcome to Windforce Bank!{customer.FullName}. Your account is {customer.customerAccountType}");
      }
    }
      public static bool IsInputValid(string userInput){
            bool IsValid=false;
            if (userInput == "1")
            {
                customer.customerAccountType = AccountType.KidStarter;
                IsValid = true;
            }
            else if (userInput == "2")
            {
                customer.customerAccountType = AccountType.Savings;
                IsValid = true;
            }
            else if (userInput == "3")
            {
                customer.customerAccountType = AccountType.Student;
                IsValid=true;
            }
            else{
                IsValid = false;
            }
            return IsValid;
        }
    }
}
