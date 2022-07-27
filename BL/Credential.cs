using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DL;

namespace POS.BL
{
    internal class Credential
    {
        private string username;
        private string password;
        private string role;
        public Credential(string username,string password,string role)
        {
            this.username = username;   
            this.password = password;
            this.role = role;
        }
        public string getUsername()
        {
           return username;
        }
        public string getPassword()
        {
            return password;
        }
        public string getRole()
        {
            return role;
        }
        public  string checkUser(Credential login)
        {
            string role ="";
            foreach (Credential cred in CredentialDL.credentialList)
            {
                if(login.username==cred.username && login.password == cred.password && login.role=="admin")
                {
                    role= "admin";
                }
                else if (login.username == cred.username && login.password == cred.password && login.role == "customer")
                {
                    role= "customer";
                }
            }
            return role;
        } 

    }
}
