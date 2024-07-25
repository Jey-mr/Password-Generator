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
            this.Close();
        }

        private void store_Click(object sender, EventArgs e)
        {
            string encryptedPassword = Encrypt(_password);
            string decryptedPassword = Decrypt(encryptedPassword);
            Database pg = new Database();
            bool inserted = pg.Insert(_url, _userName, encryptedPassword);

            //MessageBox.Show("Encrypted Password: " + encryptedPassword + "\nDecrypted Password: " + decryptedPassword + "\nInserted: " + inserted);
            MessageBox.Show("Your password has been stored.");
            this.Close();
        }

        public static string Encrypt(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] encryptedDataBytes = ProtectedData.Protect(dataBytes, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedDataBytes);
        }

        public static string Decrypt(string encryptedData)
        {
            byte[] encryptedDataBytes = Convert.FromBase64String(encryptedData);
            byte[] decryptedBytes = ProtectedData.Unprotect(encryptedDataBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decryptedBytes);
        }

    }
}
