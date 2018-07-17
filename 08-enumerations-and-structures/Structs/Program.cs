using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactInfo contactInfo;
            contactInfo.HomeAddress="5, Edidi Lane, Idumota, Lagos";
            contactInfo.EmailAddress="someone@example.com";
            contactInfo.PhoneNumber="+2348012345678";

            ContactInfo anotherInfo;
            anotherInfo=contactInfo;
            Console.WriteLine(anotherInfo.PhoneNumber);


            AccountInfo accountInfo;
            accountInfo.AccountNumber="12345678";
            accountInfo.AccountName="Julius Roberts";
            accountInfo.AccountType=AccountType.Current;
            Console.WriteLine(accountInfo.AccountType);
        }
     
    }
    struct ContactInfo
    {
        public string EmailAddress;
        public string HomeAddress;
        public string PhoneNumber;
    }
    struct AccountInfo
    {
        public string AccountName;
        public string AccountNumber;
        public AccountType AccountType;
    }
    enum AccountType
    {
        Savings, Current, Corporate
    }
   
}
