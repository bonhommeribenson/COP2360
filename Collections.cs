using System;
using System.Collections.Generic;
using System.Linq;
                                                                                            //this program allow users to manage student information using a Dictionary
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Student Dictionary");

                                                                                            // Step 2: Create a dictionary to store student IDs and their courses.
        Dictionary<string, List<string>> studentCourses = new();
                                                                                            //  Add some sample student data to the dictionary.
        studentCourses["S001"] = new() { "Math", "Science" };
        studentCourses["S002"] = new() { "English", "History" };
        studentCourses["S003"] = new() { "Biology", "Chemistry" };

                                                                                             // Repeat the menu until the user chooses to exit.
        string choice;

        do
        {
                                                                                             // Display the main menu for dictionary operations.
            Console.WriteLine("\n==== Main Menu ====");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary contents");
            Console.WriteLine("3. Remove a key");
            Console.WriteLine("4. Add new key and value");
            Console.WriteLine("5. Add value to Existing key");
            Console.WriteLine("6. Sort keys");
            Console.WriteLine("0. Exit");

                                                                                                        // Ask the user to enter their choice from the main menu.
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine() ?? "";
            switch (choice)
            {                                                                                           // Display the dictionary contents based on user choice
                case "1":
                    Console.WriteLine("You selected Populate Dictionary.");
                    break;
                case "2":
                    Console.WriteLine("You selected Display Dictionary Contents.");
                    foreach (var student in studentCourses)
                    {
                        Console.WriteLine($"Student ID: {student.Key}");
                        Console.WriteLine("Courses: " + string.Join(", ", student.Value));
                        Console.WriteLine();
                    }
                    break;
                                                                                                        // step3: Remove a student from the dictionary.
                case "3":
                    Console.Write("Enter Student ID to remove: ");
                    string studentIdToRemove = Console.ReadLine() ?? "";
                    if (studentCourses.Remove(studentIdToRemove))
                    {
                        Console.WriteLine($"Student ID {studentIdToRemove} removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Student ID {studentIdToRemove} not found.");
                    }
                    break;
                                                                                                                // Step 4: Add new key and value to the dictionary.
                case "4":
                    Console.Write("Enter new Student ID: ");
                    string newStudentId = Console.ReadLine() ?? "";
                    Console.Write("Enter courses for the student (comma-separated): ");
                    string coursesInput = Console.ReadLine() ?? "";
                    List<string> courses = coursesInput.Split(',').Select(c => c.Trim()).ToList();
                    studentCourses[newStudentId] = courses;
                    Console.WriteLine($"Student ID {newStudentId} added successfully.");
                    break;
                                                                                                                // Step 5: Add value to existing key in the dictionary.
                case "5":
                    Console.Write("Enter Student ID to add courses to: ");
                    string existingStudentId = Console.ReadLine() ?? "";
                    if (studentCourses.ContainsKey(existingStudentId))
                    {
                        Console.Write("Enter courses to add (comma-separated): ");
                        string additionalCoursesInput = Console.ReadLine() ?? "";
                        List<string> additionalCourses = additionalCoursesInput.Split(',').Select(c => c.Trim()).ToList();
                        studentCourses[existingStudentId].AddRange(additionalCourses);
                        Console.WriteLine($"Courses added to Student ID {existingStudentId} successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Student ID {existingStudentId} not found.");
                    }
                    break;
                                                                                                                            // Step 6: Sort keys in the dictionary.
                case "6":
                    var sortedKeys = studentCourses.Keys.OrderBy(k => k).ToList();
                    Console.WriteLine("Sorted Student IDs:");
                    foreach (var key in sortedKeys)
                    {
                        Console.WriteLine(key);
                    }
                    break;

                case "0":
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != "0");
    }
}
