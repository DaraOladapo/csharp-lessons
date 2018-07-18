using System;
using System.Collections.Generic;
using System.Text;

namespace ClassyFeeling
{
    public class EducationInfo
    {
        public string Institution { get; set; }
        public string Qualification { get; set; }
        public int YearOfGraduation { get; set; }
        public ClassOfDegree DegreeClass { get; set; }
    }
    public enum ClassOfDegree
    {
        FirstClass,
        SecondClassUpper,
        SecondClassLower,
        ThirdClass,
        Pass,
        Merit,
        Distinction,
        UpperCredit,
        LowerCredit
    }
}
