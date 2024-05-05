using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpShellCore;

namespace Registration_Student;

 class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        static void RegisterStudent()
        {
            var newStudent = new Student();

            Console.Write("Enter student ID: ");
            newStudent.StudentId = Console.ReadLine();
            Console.Write("Enter firstname: ");
            newStudent.Firstname = Console.ReadLine();
            Console.Write("Enter lastname: ");
            newStudent.Lastname = Console.ReadLine();
            Console.Write("Enter midllename: ");
            newStudent.Middlename = Console.ReadLine();
            Console.Write("Enter enrolled program: ");
            newStudent.Program = Console.ReadLine();

            students.Add(newStudent);
            Console.WriteLine("Success! New Student registered.");
        }

        static void DisplayAllStudents()
        {
            Console.WriteLine("List of registered students");
            foreach (var student in students)
            {
                Console.WriteLine($"Student Id: {student.StudentId}");
                Console.WriteLine($"Student Name: {student.Lastname}, {student.Firstname}, {student.Middlename}");
                Console.WriteLine($"Program: {student.Program}");
                Console.WriteLine("=============================================");
            }
        }

        static void DeleteStudent()
        {
            Console.Write("Enter the student ID to delete: ");
            string studentId = Console.ReadLine();

            Student studentToDelete = students.Find(student => student.StudentId == studentId);

            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);
                Console.WriteLine("Student record deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student record not found.");
            }
        }

        static void UpdateStudent()
        {
            Console.Write("Enter the student ID to update: ");
            string studentId = Console.ReadLine();

            Student studentToUpdate = students.Find(student => student.StudentId == studentId);

            if (studentToUpdate != null)
            {
                Console.WriteLine("Enter updated information:");
                Console.Write("Enter firstname: ");
                studentToUpdate.Firstname = Console.ReadLine();
                Console.Write("Enter lastname: ");
                studentToUpdate.Lastname = Console.ReadLine();
                Console.Write("Enter midllename: ");
                studentToUpdate.Middlename = Console.ReadLine();
                Console.Write("Enter enrolled program: ");
                studentToUpdate.Program = Console.ReadLine();

                Console.WriteLine("Student record updated successfully.");
            }
            else
            {
                Console.WriteLine("Student record not found.");
            }
        }

        static void Menu()
        {
            bool exitApp = true;
            while (exitApp)
            {
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
				Console.WriteLine(" ");
				Console.WriteLine("     ||Welcome to Student Registration System!||     ");
				Console.WriteLine(" ");
		    	Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
				Console.WriteLine(" ");
				Console.WriteLine("OPTIONS:");
                Console.WriteLine("[1] Register Student [2] Display Students [3] Delete Student [4] Update Student [5] Exit");
                Console.Write("Enter choice: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        string answer = "y";
                        while (answer == "y" || answer == "Y")
                        {
                            RegisterStudent();
                            Console.Write("Add Student? [y/n]:");
                            answer = Console.ReadLine();
                        }
                        break;

                    case 2:
                        DisplayAllStudents();
                        break;

                    case 3:
                        DeleteStudent();
                        break;

                    case 4:
                        UpdateStudent();
                        break;

                    case 5:
                        exitApp = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        public class Student
        {
            public string StudentId { get; set; }
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string Middlename { get; set; }
            public string Program { get; set; }
        }
    }

