using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Windows.Forms.LinkLabel;

namespace PasswordGenerator.PGClasses
{
    internal class Disk
    {
        public bool StorePassword(string url, string userName, string password)
        {
            Password passwordObj = new Password()
            {
                Url = url,
                UserName = userName,
                UserPassword = password
            };

            string docPath = "C:\\Users\\Jeygm\\OneDrive\\Desktop\\PasswordGenerator\\PGClasses\\password.txt";
            string temp = File.ReadAllText(docPath);
            string json = "";
            bool isStored = false;

            using (StreamWriter sw = File.AppendText(docPath))
            {
                json = JsonConvert.SerializeObject(passwordObj, Formatting.Indented);

                if(temp.Length > 0)
                {
                    sw.Write(",\n");
                }

                sw.Write(json);
                isStored = true;
            }

            return isStored;
        }
    }

    public class Password
    {
        public string Url { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
