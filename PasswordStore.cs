using PasswordGenerator.PGClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordStore : Form
    {
        private string _url;
        private string _userName;
        private string _password;

        public PasswordStore()
        {
            InitializeComponent();
        }

        public PasswordStore(string url, string userName, string password)
        {
            InitializeComponent();
            _url = url;
            _userName = userName;
            _password = password;
            passwordLabel.Text = _password;
        }

        private void ignore_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("_password: " + _password);
            this.Close();
        }

        private void store_Click(object sender, EventArgs e)
        {
            if (StoreInDisk())
            { 
                MessageBox.Show("Your password has been stored");
            }
            else
            {
                MessageBox.Show("An error has been occurred while storing your password");
            }

            this.Close();
        }

        public bool StoreInDisk()
        {
            Disk d = new Disk();
            string encryptedPassword = Security.Encrypt(_password);
            return d.StorePassword(_url, _userName, encryptedPassword);
        }

        public bool StoreInDatabase()
        {
            Database db = new Database();
            string encryptedPassword = Security.Encrypt(_password);
            return db.Insert(_url, _userName, encryptedPassword);
        }
    }
}
