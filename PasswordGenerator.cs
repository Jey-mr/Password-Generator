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
            Console.WriteLine("Minimum number of chars: "+minChars.Text);
            Console.WriteLine("Number of upper case: "+upperCase.Text);
            Console.WriteLine("Number of special chars: "+specialChars.Text);
        }
    }
}
