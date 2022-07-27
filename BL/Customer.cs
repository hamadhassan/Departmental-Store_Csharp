using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DL;

namespace POS.BL
{
    internal class Customer
    {
        private string name;// product name
        private int quantity;
        public Customer(string name,int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
        public string  getCustomerNameProduct()
        {
            return name;
        }
        public int getCustomerQuantity()
        {
            return quantity;
        }
        public  Customer setBuyProduct(Customer newOrder)
        {
            foreach (Product pro in ProductDL.productList)
            {
                if (pro.getName() == newOrder.name)
                {
                    if (pro.getStockQuantity() >= newOrder.quantity)
                    {
                        int stock=pro.getStockQuantity();
                        stock-=newOrder.quantity;
                        pro.setStockQuantity(stock);
                        Customer updatedOrder;
                        updatedOrder = new Customer(newOrder.name, newOrder.quantity);
                        return updatedOrder;
                    }
                }
            }
            return null;
        }
        public  string setBuyProductConstrine(Customer newOrder)
        {
            string message="";
            if (ProductDL.productList !=null)
            {
                foreach (Product pro in ProductDL.productList)
                {
                    if (pro.getName() == newOrder.name)
                    {
                        if (pro.getStockQuantity() >= newOrder.quantity)
                        {
                            message = "Successfully product has been buy";
                            break;
                        }
                        else
                        {
                            message = "Sorry! we are not avilable at that time";

                        }
                    }
                    else
                    {
                        message = "Sorry! we are not avilable at that time";

                    }
                }
            }
            else
            {
                message = "Sorry! we are not avilable at that time";
            }
            return message;
        }
        public double getTaxAmount(string productCategory,float productPrice)
        {
            double taxAmount;
            if (productCategory == "Grocery" || productCategory == "grocery")
            {
                taxAmount= productPrice * 0.10;
            }
            else if (productCategory == "Fruit" || productCategory == "fruit")
            {
                taxAmount = productPrice * 0.05;
            }
            else
            {
                taxAmount = productPrice * 0.15;
            }
            return taxAmount;
        }
    }
}
