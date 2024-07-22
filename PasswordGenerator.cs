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
            int minCharsVariable, upperCaseVariable, specialCharsVariable, randomValue;
            char[] specialCharsArr = {'!', '@', '#', '$', '%', '^', '&', '*'};
            Random random = new Random();   

            try
            {
                minCharsVariable = (minChars.Text.Length > 0) ? Int32.Parse(minChars.Text) : 0;
                upperCaseVariable = (upperCase.Text.Length > 0) ? Int32.Parse(upperCase.Text) : 0;
                specialCharsVariable = (specialChars.Text.Length > 0) ? Int32.Parse(specialChars.Text) : 0;
            }
            catch (Exception e)
            {
                return "Invalid Constraints";
            }

            string temporaryPassword = "";

            while (upperCaseVariable > 0  ||  specialCharsVariable > 0)
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
                    randomValue = random.Next(upperCaseVariable + 1);

                    while (randomValue > 0)
                    {
                        char c = (char)('A' + random.Next(26));
                        temporaryPassword += c;
                        randomValue--;
                        upperCaseVariable--;
                    }
                }
                else 
                {
                    randomValue = random.Next(specialCharsVariable + 1);

                    while (randomValue > 0)
                    {
                        char c = specialCharsArr[random.Next(specialCharsArr.Length)];
                        temporaryPassword += c;
                        randomValue--;
                        specialCharsVariable--;
                    }
                }
            }

            minCharsVariable = minCharsVariable - temporaryPassword.Length;

            if (minCharsVariable > 0)
            {
                while (minCharsVariable > 0)
                {
                    char c = (char)('a' + random.Next(26));
                    temporaryPassword += c;
                    minCharsVariable--;
                }
            }

            password += temporaryPassword;

            return password;
        }

        private void Clear()
        {
            minChars.Text = "";
            upperCase.Text = "";
            specialChars.Text = "";
        }
    }
}
