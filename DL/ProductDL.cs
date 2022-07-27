using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using System.IO;
namespace POS.DL
{
    internal class ProductDL
    {
        public static List<Product> productList = new List<Product>();
        public static void setIntoProductList(Product newProduct)
        {
            productList.Add(newProduct);
        }
        public static void storeintoFileCustomer(string path, Product newProduct)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(newProduct.getName() + "," + newProduct.getCategory()+","+ newProduct.getPrice()+","+newProduct.getStockQuantity()+","+newProduct.getThreshodQuantity());
            f.Flush();
            f.Close();
        }
        public static void readFromFileCustomer(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name=splittedRecord[0];
                    string category=splittedRecord[1];
                    float price=float.Parse(splittedRecord[2]);
                    int stockQuantity=int.Parse(splittedRecord[3]);
                    int threshodQuantity=int.Parse(splittedRecord[4]);
                    Product newProduct=new Product(name,category,price,stockQuantity,threshodQuantity);
                    setIntoProductList(newProduct);
                }
                f.Close();
            }
        }
    }
}
