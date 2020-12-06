using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> studentList = new List<Student>();
            for (int i = 0; i <studentsCount; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split();
                Student newStudent = new Student(cmd[0], cmd[1], double.Parse(cmd[2]));
                studentList.Add(newStudent);
            }
            studentList= studentList.OrderByDescending(a=>a.Grade)
                .ToList();
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(studentList[i].ToString());
            }
        }
    }
    class Student
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public double Grade{ get; set; }
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName ;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
