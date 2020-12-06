using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //Pesho 3
                string[] cmd = Console.ReadLine()
                    .Split();
                Person newPerson = new Person(cmd[0], int.Parse(cmd[1]));
                family.AddFamilyMember(newPerson); 
            }
            Console.WriteLine(family.GetOldestMember(family).ToString());
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
    class Family
    {
        public List<Person> Members { get; set; } = new List<Person>();
        public void AddFamilyMember(Person newMember)
        {
            Members.Add(newMember);
        }
        public Person GetOldestMember(Family family)
        {
            Person oldestMember = family.Members.OrderByDescending(x => x.Age).First();
            return oldestMember;
        }
    }
}
