using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input=Console.ReadLine()
                .Split();
            List<Box> boxes = new List<Box>();
            while (input[0]!="end")
            {
                //19861519 Dove 15 2.50
                int serialNumber = int.Parse(input[0]);
                string item = input[1];
                int quantity = int.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);
                Item currentItem = new Item();
                currentItem.Name = item;
                currentItem.Price = itemPrice;
                Box currentBox = new Box();
                currentBox.SerialNumber = serialNumber;
                currentBox.Item = currentItem.Name;
                currentBox.ItemQuantity = quantity;
                currentBox.BoxPrice = currentItem.Price * quantity;
                boxes.Add(currentBox);
                input = Console.ReadLine()
                .Split();
            }
            List<Box> sorted = boxes
                .OrderBy(boxes => boxes.BoxPrice)
                .Reverse()
                .ToList();
            foreach (Box x in sorted)
            {
                Console.WriteLine(x.SerialNumber);
                Console.WriteLine($"-- {x.Item} - ${(x.BoxPrice / x.ItemQuantity):F2}: {x.ItemQuantity}");
                Console.WriteLine($"-- ${x.BoxPrice:F2}");
            }
            
        }
        
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public int SerialNumber{ get; set; }
        public string Item{ get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice{ get; set; }
        
    }
}
