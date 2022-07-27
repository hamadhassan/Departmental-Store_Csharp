using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using POS.DL;
using POS.UL;

namespace POS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathCredential = "credential.txt";
            string pathCustomer = "customer.txt";
            string pathProduct = "product.txt";
            CredentialDL.readFromFileCredential(pathCredential);
            ProductDL.readFromFileCustomer(pathProduct);
            CustomerDL.readFromFileCustomer(pathCustomer);
            while (true)
            {
                char option = CredentialUL.mainMenu();
                if (option == '1')
                {
                    Credential login = CredentialUL.getInputForCredential();
                    string role = login.checkUser(login);
                    if (role == "admin")
                    {
                        while (true)
                        {
                            MiscUL.clearScreen();
                            char op = ProductUL.adminMenu();
                            if (op == '1')
                            {
                                Product newProduct = ProductUL.getInputforAddProduct();
                                ProductDL.setIntoProductList(newProduct);
                                ProductDL.storeintoFileCustomer(pathProduct, newProduct);
                            }
                            else if (op == '2')
                            {
                                ProductUL.viewAllProduct();
                            }
                            else if (op == '3')
                            {
                                ProductUL.viewHightestUnit();
                            }
                            else if (op == '4')
                            {
                                ProductUL.viewTaxOFAllProduct();
                            }
                            else if (op == '5')
                            {
                                ProductUL.viewThresholdProducts();
                            }
                            else if (op == '6')
                            {
                                break;
                            }
                        }
                    }
                    else if (role == "customer")
                    {
                        while (true)
                        {
                             MiscUL.clearScreen();
                            char op = CustomerUL.customerMenu();
                            if(op == '1')
                            {
                                ProductUL.viewAllProduct();
                            }
                            else if(op == '2')
                            {
                                Customer updateStock =CustomerUL.getInputForBuyProduct();
                                CustomerDL.setIntoCustomerList(updateStock);
                                CustomerDL.storeintoFileCustomer(pathCustomer,updateStock);
                            }
                            else if(op == '3')
                            {
                                CustomerUL.viewInvoice();
                            }
                            else if(op=='4')
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid UserName and Password");
                    }
                }
                else if (option == '2')
                {
                    Credential newUser = CredentialUL.getInputForCredential();
                    CredentialDL.storeintoFileCredential(pathCredential,newUser);
                    CredentialDL.setIntoCredentialList(newUser);
                }
                else if (option == '3')
                {
                    break;
                }
                MiscUL.clearScreen();
            }
            Console.ReadLine();
        }
    }
}
