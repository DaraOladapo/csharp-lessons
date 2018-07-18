using System;
using System.Collections.Generic;
using System.Text;

namespace ClassyFeeling
{
    public class NextOfKin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Relationship RelationshipWith { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
    }
    public enum Relationship
    {
        Brother,
        Sister,
        Father,
        Mother,
        Uncle,
        Aunt,
        Cousin,
        Husband,
        Wife,
        Daughter,
        Son
    }
}
