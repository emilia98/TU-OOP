﻿using System;

namespace Project_Student
{
    public class Student
    {
        // field
        private string firstName;

        // field
        private string middleName;

        // field
        private string lastName;

        // field
        private string facultyNumber;

        // field
        private string course;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName == null ? "" : " " + this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
        }

        public string Course
        {
            get { return this.course == null ? "N/A" : this.course; }
        }

        public Student()
        {
            Console.Write("First name: ");
            this.firstName = Console.ReadLine();
            Console.Write("Middle name: ");
            this.middleName = Console.ReadLine();
            Console.Write("Last name: ");
            this.lastName = Console.ReadLine();
            Console.Write("Course: ");
            this.course = Console.ReadLine();
            Console.Write("Faculty number: ");
            this.facultyNumber = Console.ReadLine();
            Console.WriteLine(new string('-', 15));
        }

        public Student(string firstName, string lastName, string facultyNumber)
        {
            this.firstName = firstName;
            this.middleName = null;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.course = null;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{this.FirstName}{this.MiddleName} {this.LastName}");
            Console.WriteLine($"Faculty number: {this.FacultyNumber}");
            Console.WriteLine($"Course: {this.Course}");
        }

        public bool IsMatchingFacultyNumber(string result)
        {
            return this.FacultyNumber.Contains(result);
        }
    }
}
