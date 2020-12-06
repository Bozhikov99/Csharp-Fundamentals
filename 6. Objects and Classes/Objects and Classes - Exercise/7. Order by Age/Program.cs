using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _7._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmd = Console.ReadLine()
                .Split();
            List<Person> listum = new List<Person>();
            while (cmd[0]!="End")
            {
                Person person = new Person(cmd[0], cmd[1], int.Parse(cmd[2]));
                listum.Add(person);
                cmd= Console.ReadLine()
                    .Split();
            }
            List<Person> sorted = listum
                .OrderBy(x => x.Age)
                .ToList();
            foreach (Person x in sorted )
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age= age;
        }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
