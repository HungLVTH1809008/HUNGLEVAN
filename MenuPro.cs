using System;
using System.Collections.Generic;

namespace T1809E_CShar
{
    public class MenuPro
    {
        public static void Main(string[] args)
        {
            Product pr = new Product();

            bool start = true;
            List<Product> list =new List<Product>();

            while (start)
            { 
                ShowMenu();
                int menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                    Add product;
                        case 2: Disphay product records;
                            case 3:Delete product by id;
                                case 4: Exit;
                                    start = false; break;
                                    ;
                }
            }


        }
        static void ShowMenu()
        {
            Console.WriteLine("Chon chuc nang");
            Console.WriteLine("1. Add product ");
            Console.WriteLine("2.Disphay product records");
            Console.WriteLine("3.Delete product by id");
            Console.WriteLine("4. Exit");
        }

    }
}