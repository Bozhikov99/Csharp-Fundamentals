
using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes___More_Exercise
{
    class Program //Company Roster
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Department> departamentsList = new List<Department>();
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split();
                if (!departamentsList.Any(x => x.Name == cmd[2]))
                {
                    Department newDep = new Department(cmd[2]);
                    Employee newEmp = new Employee(cmd[0], double.Parse(cmd[1]));
                    departamentsList.Add(newDep);
                }
                departamentsList.Find(x => x.Name == cmd[2]).AddEmployee(cmd[0], double.Parse(cmd[1]));
            }
            Department bestDepartment = departamentsList.OrderByDescending(x => x.TotalSalary/x.EmployeeList.Count).First();
            Console.WriteLine($"Highest Average Salary: {bestDepartment.Name}");
           
            foreach (Employee z in bestDepartment.EmployeeList.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{z.Name} {z.Salary:F2}");
            }
        }

    }
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
    class Department
    {
        public string Name { get; set; }
        public List<Employee> EmployeeList { get; set; } = new List<Employee>();
        public double TotalSalary { get; set; }
        public Department(string name)
        {
            Name = name;
        }
        public void AddEmployee(string name, double salary)
        {
            TotalSalary += salary;
            EmployeeList.Add(new Employee(name, salary));
        }
    }
}
