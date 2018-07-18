using System;
using System.Collections.Generic;
using System.Text;

namespace ClassyFeeling
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderType Gender { get; set; }
        public Genotypes Genotype { get; set; }
        public BloodGroups BloodGroup{ get; set; }
        public string Nationality { get; set; }
        public string StateOfOrigin { get; set; }
    }
    public enum GenderType
    {
        Male,Female,Others
    }
    public enum Genotypes
    {
        AA, AC,AS,SS, SC, CC
    }
    public enum BloodGroups
    {
        APositive,ANegative,BPositive,BNegative,AB,OPositive,ONegative
    }
}
