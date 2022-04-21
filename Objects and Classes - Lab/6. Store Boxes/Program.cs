using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    internal class Program
    {
        class Box
        {
            public string SerialNum { get; set; }
            public string Item { get; set; }
            public int Quantity { get; set; }
            public double PriceBox { get; set; }
            public double TotalPrice { get; set; }
        }

        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            double totalPrice = 0;
            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] arr = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string serialNum = arr[0];
                string item = arr[1];
                int quantity = int.Parse(arr[2]);
                double priceBox = double.Parse(arr[3]);

                totalPrice = priceBox * quantity;

                Box box = new Box();

                box.SerialNum = serialNum;
                box.Item = item;
                box.Quantity = quantity;
                box.PriceBox = priceBox;
                box.TotalPrice = totalPrice;
                
                boxes.Add(box);
            }

            List<Box> sort = boxes.OrderBy(boxes => boxes.TotalPrice).ToList();
            sort.Reverse();

            foreach (Box box in sort)
            {
                Console.WriteLine($"{box.SerialNum}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceBox:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:F2}");
            }
        }
    }
}
