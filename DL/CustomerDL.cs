using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using POS.BL;

namespace POS.DL
{
    internal class CustomerDL
    {
        public static List<Customer> customerList=new List<Customer>();
        public static void setIntoCustomerList(Customer newOrder)
        {
            customerList.Add(newOrder);
        }
        public static void storeintoFileCustomer(string path, Customer newOrder)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(newOrder.getCustomerNameProduct() + "," + newOrder.getCustomerQuantity());
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
                    string name = splittedRecord[0];
                    int quantity =int.Parse( splittedRecord[1]);
                    Customer newUser = new Customer(name,quantity);
                    setIntoCustomerList(newUser);
                }
                f.Close();
            }
        }
    }
}
