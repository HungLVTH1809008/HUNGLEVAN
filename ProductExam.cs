using System;
using System.Collections.Generic;

namespace T1809E_CShar
{
    public class ProductExam
    {
        public int ID;
        public string Name;
        public double price;

        public ProductExam(int id, string name, double price)
        {
            ID = id;
            Name = name;
            this.price = price;
        }

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public void Show()
        {
            Console.WriteLine("nhap id");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" nhap gia san pham");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Nhap id "+ ID );
            Console.WriteLine("nhap ten "+ Name);
            Console.WriteLine(" nhap gia" + price);
        }

        public void Add(List<Product> list)
        {
            Console.WriteLine("nhap id");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("nhap gia ");
            price = Convert.ToDouble(Console.ReadLine());
             
            
            
        }

    }
}