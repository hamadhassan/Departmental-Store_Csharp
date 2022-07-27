using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.BL;
using System.IO;

namespace POS.DL
{
    internal class CredentialDL
    {
        public static List<Credential> credentialList = new List<Credential>();
        public static void setIntoCredentialList(Credential newUser)
        {
            credentialList.Add(newUser);
        }
        public static void storeintoFileCredential(string path, Credential newUser)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(newUser.getUsername() + "," + newUser.getPassword() + "," + newUser.getRole());
            f.Flush();
            f.Close();
        }
        public static void readFromFileCredential(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string username=splittedRecord[0];
                    string password=splittedRecord[1];
                    string role=splittedRecord[2];
                    Credential newUser = new Credential(username,password,role);
                    setIntoCredentialList(newUser);
                }
                f.Close();
            }
        }
    }
}
