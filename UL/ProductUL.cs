using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using POS.DL;

namespace POS.UL
{
    internal class ProductUL
    {
        public static char adminMenu()
        {
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. View all product");
            Console.WriteLine("3. Find product with higest unit price");
            Console.WriteLine("4. View sale tax of all product");
            Console.WriteLine("5. Product to be ordered (threshod)");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option...");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
        public static Product getInputforAddProduct()
        {
            string name;
            string category;
            float price;
            int stockQuantity;
            int threshodQuantity;
            Console.Write("Enter product name: ");
            name=Console.ReadLine();
            Console.Write("Enter product category: ");
            category = Console.ReadLine();
            Console.Write("Enter product price: ");
            price=float.Parse(Console.ReadLine()); 
            Console.Write("Enter product stock quantity: ");
            stockQuantity=int.Parse(Console.ReadLine());
            Console.Write("Enter product threshold quantity: ");
            threshodQuantity=int.Parse(Console.ReadLine());
            Product newProduct=new Product(name,category,price,stockQuantity,threshodQuantity);
            return newProduct;
        }
        public static void viewAllProduct()
        {
            foreach(Product product in ProductDL.productList)
            {
                Console.WriteLine("Product name: " + product.getName());
                Console.WriteLine("Product category: " + product.getCategory());
                Console.WriteLine("Product price: " + product.getPrice());
                Console.WriteLine("Product stock quantity: " + product.getStockQuantity());
                Console.WriteLine("------------------------------------------");
            }
        }
        public static void viewHightestUnit()
        {
            float price = ProductDL.productList[0].getPrice();
            string unitName = ProductDL.productList[0].getName();
            foreach (Product m in ProductDL.productList)
            {
                if (price < m.getPrice())
                {
                    price = m.getPrice();
                    unitName = m.getName();
                }
            }
            Console.WriteLine("Highest product price is " + unitName);
        }
        public static void viewTaxOFAllProduct()
        {
            List<string> taxlist = new List<string>();
            foreach (Product m in ProductDL.productList)
            {
                if (m.getCategory() == "Grocery" || m.getCategory() == "grocery")
                {
                    taxlist.Add(m.getName() + " 10%");
                }
                else if (m.getCategory() == "Fruit" || m.getCategory() == "fruit")
                {
                    taxlist.Add(m.getName() + " 05%");
                }
                else
                {
                    taxlist.Add(m.getName() + " 15%");
                }
            }
            foreach (string tax in taxlist)
            {
                Console.WriteLine(tax);
            }
        }
        public static void viewThresholdProducts()
        {
            List<string> thresholdProductList = new List<string>();
            foreach (Product m in ProductDL.productList)
            {
                if (m.getStockQuantity() <= m.getThreshodQuantity())
                {
                    thresholdProductList.Add(m.getName());
                }
            }
            foreach (string threshold in thresholdProductList)
            {
                Console.WriteLine(threshold);
            }
        }
    }
}
