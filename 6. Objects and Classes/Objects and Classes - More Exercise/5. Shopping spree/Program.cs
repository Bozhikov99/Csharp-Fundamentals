using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _5._Shopping_spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine()
                .Split(";",StringSplitOptions.RemoveEmptyEntries);

            List<Person> peopleList = new List<Person>();
            for (int i = 0; i < personInput.Length; i++)
            {
                string[] NameMoney = personInput[i]
                    .Split("=");
                Person newPerson = new Person(NameMoney[0], double.Parse(NameMoney[1]));
                peopleList.Add(newPerson);
            }

            string[] productInput = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Product> prodList = new List<Product>();
            for (int i = 0; i < productInput.Length; i++)
            {
                string[] prodMoney = productInput[i]
                    .Split("=");
                Product newProd = new Product(prodMoney[0], double.Parse(prodMoney[1]));
                prodList.Add(newProd);
            }
            string[] cmd = Console.ReadLine()
                .Split();
            while (cmd[0]!="END")
            {
                string personName = cmd[0];
                string prodName = cmd[1];
                Person currentPerson = peopleList.Find(x=>x.Name==personName);
                currentPerson.Buy(prodName, prodList);
                cmd = Console.ReadLine()
                .Split();
            }
            foreach (Person x in peopleList)
            {
                Console.WriteLine($"{x.ToString()}");
            }
       }
    }
    class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> ProductList { get; set; } = new List<Product>();
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
        }
        public void Buy(string name, List<Product> allProds)
        {
            Product newProd = allProds.Find(x=>x.Name==name) ;
            if (Money >= newProd.Cost)
            {    
                ProductList.Add(newProd);
                Money -= newProd.Cost;
                Console.WriteLine($"{Name} bought {name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {name}");
            }
        }
        public override string ToString()
        {
            if (ProductList.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                return $"{Name} - {sb.AppendJoin(", ", ProductList.Select(x => x.Name))}";
            }
            else
            {
                return $"{Name} - Nothing bought";
            }
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
            
        }
    }
}
