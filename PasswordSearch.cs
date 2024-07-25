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

            }
        }

        private void FetchFromDatabase(string url)
        {
            Database db = new Database();
            DataTable dt = db.FindByURL(url);
            string? result = "";

            foreach (DataRow row in dt.Rows)
            {
                result += row["user_name"] + ": ";
                result += PasswordStore.Decrypt(row["password"].ToString());
                result += "\n";
            }
            MessageBox.Show(result);
        }
    }
}
