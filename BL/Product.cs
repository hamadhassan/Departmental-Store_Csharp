using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DL;
namespace POS.BL
{
    internal class Product
    {
        private string name;
        private string category;
        private float price;
        private int stockQuantity;
        private int threshodQuantity;
        public Product(string name,string category,float price,int stockQuantity,int threshodQuantity)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.threshodQuantity = threshodQuantity;
        }
        public string getName()
        {
            return name;
        }
        public string getCategory()
        {
            return category;
        }
        public float getPrice()
        {
            return price;
        }
        public int getStockQuantity()
        {
            return stockQuantity;
        }
        public void setStockQuantity(int stockQuantity)
        {
            this.stockQuantity=stockQuantity;
        }
        public int getThreshodQuantity()
        {
            return threshodQuantity;
        }
    }
}
