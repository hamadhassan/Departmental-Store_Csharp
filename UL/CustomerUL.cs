using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using POS.DL;

namespace POS.UL
{
    internal class CustomerUL
    {
        public static char customerMenu()
        {
            Console.WriteLine("1. View all product");
            Console.WriteLine("2. Buy the product");
            Console.WriteLine("3. Generate invoice");
            Console.WriteLine("4. Exit");
            Console.Write("Enter option ");
            char option=char.Parse(Console.ReadLine());
            return option;
        }
        public static Customer getInputForBuyProduct()
        {
            string name;
            int quantity;
            Console.Write("Enter product name: ");
            name = Console.ReadLine();
            Console.Write("Enter product quantity: ");
            quantity = int.Parse(Console.ReadLine());
            Customer newOrder=new Customer(name, quantity);
            string message = newOrder.setBuyProductConstrine(newOrder);
            viewConstrine(message);
            Customer updateStock = newOrder.setBuyProduct(newOrder);
            return updateStock;
        }
        public static void viewConstrine(string message)
        {
            Console.WriteLine(message);
        }
        public static void viewInvoice()
        {
            double totalPurchase = 0;
            foreach (Product m in ProductDL.productList)
            {
                foreach (Customer cust in CustomerDL.customerList)
                {
                    if (cust.getCustomerNameProduct() == m.getName())
                    {
                        totalPurchase += m.getPrice() + cust.getTaxAmount(m.getCategory(), m.getPrice());
                        totalPurchase *= cust.getCustomerQuantity();
                    }
                }
            }
            Console.WriteLine("Total amount after tax is "+ totalPurchase);
        }
    }
}
