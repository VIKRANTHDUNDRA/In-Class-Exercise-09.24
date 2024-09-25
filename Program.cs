using System;

namespace SchoolHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Middle School object
            MiddleSchool middleSchool = new MiddleSchool("Springfield Middle School", "Mr. Smith", 300, 6, 8);
            Console.WriteLine("Middle School Information:");
            middleSchool.DisplayInfo();
            Console.WriteLine();

            // Create a High School object
            HighSchool highSchool = new HighSchool("Springfield High School", "Ms. Johnson", 500, "Eagle Stadium");
            Console.WriteLine("High School Information:");
            highSchool.DisplayInfo();
        }
    }
}