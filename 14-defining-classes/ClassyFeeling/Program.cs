using System;

namespace ClassyFeeling
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee _Employee = new Employee()
            {
                FirstName = "James",
                LastName = "Roger",
                MiddleName="Otunda",
                DateOfBirth =DateTime.Parse("1990/06/01"),
                relationshipStatus=RelationshipStatus.Married
                //and other things
                
            };
            Console.WriteLine($"{_Employee.FirstName} " +
                $"is {_Employee.relationshipStatus}");
        }
    }
}
