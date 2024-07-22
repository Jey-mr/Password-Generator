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
            string generatedPassword = GeneratePassword();
            MessageBox.Show(generatedPassword);
            Clear();
        }

        private string GeneratePassword()
        {
            string password = "Password:\n";
            int minChars, upperCase, specialChars, randomValue;
            char[] specialCharsArr = {'!', '@', '#', '$', '%', '^', '&', '*'};
            Random random = new Random();   

            try
            {
                minChars = (textBox1.Text.Length > 0) ? Int32.Parse(textBox1.Text) : 0;
                upperCase = (textBox2.Text.Length > 0) ? Int32.Parse(textBox2.Text) : 0;
                specialChars = (textBox3.Text.Length > 0) ? Int32.Parse(textBox3.Text) : 0;
            }
            catch (Exception e)
            {
                return "Invalid Constraints";
            }

            string temporaryPassword = "";

            while (upperCase > 0  ||  specialChars > 0)
            {
                randomValue = random.Next(3);

                while (randomValue > 0)
                {
                    char c = (char)('a' + random.Next(26));
                    temporaryPassword += c;
                    randomValue--;
                }

                if (random.Next(2) == 0)
                {
                    randomValue = random.Next(upperCase + 1);

                    while (randomValue > 0)
                    {
                        char c = (char)('A' + random.Next(26));
                        temporaryPassword += c;
                        randomValue--;
                        upperCase--;
                    }
                }
                else 
                {
                    randomValue = random.Next(specialChars + 1);

                    while (randomValue > 0)
                    {
                        char c = specialCharsArr[random.Next(specialCharsArr.Length)];
                        temporaryPassword += c;
                        randomValue--;
                        specialChars--;
                    }
                }
            }

            minChars = minChars - temporaryPassword.Length;

            if (minChars > 0)
            {
                while (minChars > 0)
                {
                    char c = (char)('a' + random.Next(26));
                    temporaryPassword += c;
                    minChars--;
                }
            }

            password += temporaryPassword;

            return password;
        }

        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
