using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using Products.Entities;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ReceberDados();
            Tag(products);
        }

        static List<Product> ReceberDados()
        {
            List<Product> productlist = new List<Product>();

            Console.Write("Products quantity: ");
            var qtt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtt; i++)
            {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Product #{i+1} data");
                Console.Write("Common, used or imported (c/u/i): ");
                var type = char.Parse(Console.ReadLine());

                if (type == 'c')
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();

                    Console.Write("Price: ");
                    var price = double.Parse(Console.ReadLine());

                    productlist.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();

                    Console.Write("Price: ");
                    var price = double.Parse(Console.ReadLine());

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    var date = DateTime.Parse(Console.ReadLine());

                    productlist.Add(new UsedProduct(name, price, date));
                }
                else if (type == 'i')
                {
                    Console.Write("Name: ");
                    var name = Console.ReadLine();

                    Console.Write("Price: ");
                    var price = double.Parse(Console.ReadLine());

                    Console.Write("Customs fee: ");
                    var fee = double.Parse(Console.ReadLine());

                    productlist.Add(new ImportedProduct(name, price, fee));
                }
            }
            return productlist;
        }

        static void Tag(List<Product> showproducts)
        {
            foreach (Product each in showproducts)
            {
                Console.WriteLine(each.PriceTag());                
            }
        }
    }
}
