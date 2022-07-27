using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;

namespace POS.UL
{
    internal class CredentialUL
    {
        public static char mainMenu()
        {
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. Exit");
            Console.Write("Enter option...");
            char option=char.Parse(Console.ReadLine());
            return option;
        }
        public static Credential getInputForCredential()
        {
            string username;
            string password;
            string role;
            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
            Console.Write("Enter Role: ");
            role = Console.ReadLine();
            Credential user=new Credential(username,password,role);
            return user;
        }
    }
}
