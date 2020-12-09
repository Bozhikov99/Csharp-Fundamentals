using System;
using System.Collections.Generic;

namespace Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            string[] cmd = Console.ReadLine()
                .Split();

            while (cmd[0] != "end")
            {
                Student student = new Student();
                //John Smith 15 Sofia
                student.firstName = cmd[0];
                student.lastName = cmd[1];
                if (!StudentExists(studentsList, student.firstName, student.lastName))
                {

                    student.Age = cmd[2];
                    student.Hometown = cmd[3];
                    studentsList.Add(student);
                }
                else
                {
                    Student existingStud = GetStudent(studentsList, student.firstName, student.lastName);
                    existingStud.Age = cmd[2];
                    existingStud.Hometown = cmd[3];
                }
                cmd = Console.ReadLine()
                .Split();
            }
            string townFilter = Console.ReadLine();

            foreach (Student s in studentsList)
            {
                if (s.Hometown == townFilter)
                {
                    Console.WriteLine($"{s.firstName} {s.lastName} is {s.Age} years old.");
                }
            }
        }
        static bool StudentExists(List<Student> students, string firstName, string lastName)
        {
            bool exists = false;
            foreach (Student x in students)
            {
                if (firstName == x.firstName && lastName == x.lastName)
                {
                    exists = true ;
                    break;
                }     
            }
            return exists;
        }
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStud = null;
            foreach (Student x in students)
            {
                if (firstName==x.firstName&&lastName==x.lastName)
                {
                    existingStud = x;
                    break;
                }
            }
            return existingStud;
        }
    }
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Age { get; set; }
        public string Hometown { get; set; }
    }
    
}
