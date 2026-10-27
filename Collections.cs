using System;
using System.Collections.Generic;
    //this program allows users to manage student information using a Dictionary
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Student Dictionary");
    }
}
    // Step 2: Create a dictionary to store student IDs and their courses.
Dictionary<string, List<string>> studentCourses = new Dictionary<string, List<string>>();

