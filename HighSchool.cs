using System;

namespace SchoolHierarchy
{
    // Derived class for High School
    public class HighSchool : School
    {
        // Property specific to High School
        public string SportsFieldName { get; set; }

        // Constructor
        public HighSchool(string name, string principal, int studentCount, string sportsFieldName)
            : base(name, principal, studentCount)
        {
            SportsFieldName = sportsFieldName;
        }

        // Override method to display high school information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Sports Field Name: {SportsFieldName}");
        }
    }
}