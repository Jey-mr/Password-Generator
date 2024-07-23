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
        private string _password;
        public PasswordStore()
        {
            InitializeComponent();
        }

        public PasswordStore(string password)
        {
            InitializeComponent();
            _password = password;
            passwordLabel.Text = _password;
        }

        private void ignore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void store_Click(object sender, EventArgs e)
        {
            string encryptedData = Encrypt(_password);
            string decryptedData = Decrypt(encryptedData);

            MessageBox.Show("Encrypted Data: " + encryptedData + "\nDecrypted Data: " + decryptedData);
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
