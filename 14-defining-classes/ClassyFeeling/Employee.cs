using System;

namespace ClassyFeeling
{
    public class Employee : Person
    {
        public int ID { get; set; }
        public ContactInfo contactInfo { get; set; }
        public EducationInfo educationInfo { get; set; }
        public NextOfKin nextOfKin { get; set; }
        public RelationshipStatus relationshipStatus { get; set; }
    }

}