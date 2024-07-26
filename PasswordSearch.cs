using Newtonsoft.Json;
using PasswordGenerator.PGClasses;
using System.Data;

namespace PasswordGenerator
{
    public partial class PasswordSearch : Form
    {
        public PasswordSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? url = urlBox.Text;

            if (url == null)
            {
                MessageBox.Show("Enter an url");
            }
            else if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                MessageBox.Show("Enter a valid url!");
            }
            else
            {
                FetchFromDisk(url);
            }
        }

        private void FetchFromDisk(string url)
        {
            Disk disk = new Disk();
            List<Password> ps = disk.FindByUrl(url);
            string result = "{\n";

            foreach (Password p in ps)
            {
                if (url.Equals(p.Url))
                {
                    result += "    ";
                    result += "\"" + p.UserName + "\" : ";
                    result += Security.Decrypt(p.UserPassword);
                    result += "\n";
                }
            }

            result += "}";

            MessageBox.Show(result);
        }

        private void FetchFromDatabase(string url)
        {
            Database db = new Database();
            DataTable dt = db.FindByURL(url);
            string? result = "";

            foreach (DataRow row in dt.Rows)
            {
                result += row["user_name"] + ": ";
                result += Security.Decrypt(row["password"].ToString());
                result += "\n";
            }
            MessageBox.Show(result);
        }
    }
}
