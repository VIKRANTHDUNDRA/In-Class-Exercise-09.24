using System;

namespace SchoolHierarchy
{
    // Base class
    public class School
    {
        // Properties of the School class
        public string Name { get; set; }
        public string Principal { get; set; }
        public int StudentCount { get; set; }

        // Constructor
        public School(string name, string principal, int studentCount)
        {
            Name = name;
            Principal = principal;
            StudentCount = studentCount;
        }

        // Method to display school information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"School Name: {Name}");
            Console.WriteLine($"Principal: {Principal}");
            Console.WriteLine($"Student Count: {StudentCount}");
        }
    }
}