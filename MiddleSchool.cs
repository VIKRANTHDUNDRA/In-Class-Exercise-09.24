using System;

namespace SchoolHierarchy
{
    // Derived class for Middle School
    public class MiddleSchool : School
    {
        // Properties specific to Middle School
        public int LowestGrade { get; set; }
        public int HighestGrade { get; set; }

        // Constructor
        public MiddleSchool(string name, string principal, int studentCount, int lowestGrade, int highestGrade)
            : base(name, principal, studentCount)
        {
            LowestGrade = lowestGrade;
            HighestGrade = highestGrade;
        }

        // Override method to display middle school information
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Lowest Grade: {LowestGrade}");
            Console.WriteLine($"Highest Grade: {HighestGrade}");
        }
    }
}