using System;
using System.Collections.Generic;

namespace Students
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
                student.Age = cmd[2];
                student.Hometown = cmd[3];
                studentsList.Add(student);

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
        class Student
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string Age { get; set; }
            public string Hometown { get; set; }
        }
    }

}
