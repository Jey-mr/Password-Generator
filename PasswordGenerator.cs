namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {
            string mchars = textBox1.Text;
            string uc = textBox2.Text;
            string sc = textBox3.Text;

            string constraints = "Min no. of chars: " + mchars + "\nNo. of upper case: " + uc + "\nNo. of special chars: " + sc;
            MessageBox.Show(constraints);
            Clear();
        }

        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
