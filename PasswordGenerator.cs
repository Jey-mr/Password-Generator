using PasswordGenerator.PGClasses;
using System.Data;

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
            NewTable nt = new NewTable();
            /*
            DataTable dt = nt.Select();
            DataRowCollection rows = dt.Rows;
            DataRow row = rows[0];
            string? generatedPassword = row["Name"].ToString();
            */

            string? generatedPassword = nt.Insert().ToString();
            MessageBox.Show(generatedPassword);
            Clear();
        }

        private string GeneratePassword()
        {
            string password = "Password:\n";
            int minCharsVariable, upperCaseVariable, specialCharsVariable, maxCharsVariable, randomValue;
            char[] specialCharsArr = {'!', '@', '#', '$', '%', '^', '&', '*'};
            Random random = new Random();   

            try
            {
                minCharsVariable = (minChars.Text.Length > 0) ? Int32.Parse(minChars.Text) : 0;
                upperCaseVariable = (upperCase.Text.Length > 0) ? Int32.Parse(upperCase.Text) : 0;
                specialCharsVariable = (specialChars.Text.Length > 0) ? Int32.Parse(specialChars.Text) : 0;
                maxCharsVariable = (maxChars.Text.Length > 0) ? Int32.Parse(maxChars.Text) : upperCaseVariable + specialCharsVariable;
            }
            catch (Exception e)
            {
                return "Invalid Constraints";
            }

            if (minCharsVariable == 0  &&  upperCaseVariable == 0  &&  specialCharsVariable == 0  &&  maxCharsVariable == 0)
            {
                minCharsVariable = maxCharsVariable = random.Next(8, 16);
            }

            if (minCharsVariable > maxCharsVariable)
            {
                return "Min chars must be less than or equal to Max chars";
            }

            if (upperCaseVariable + specialCharsVariable  >  maxCharsVariable)
            {
                return "Max chars must be greator than or equal to the sum of upper case and special chars";
            }

            if (upperCaseVariable + specialCharsVariable > minCharsVariable)
            {
                minCharsVariable = upperCaseVariable + specialCharsVariable;
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

            int tempMinCharsVariable = minCharsVariable - temporaryPassword.Length;

            if (tempMinCharsVariable > 0)
            {
                while (tempMinCharsVariable > 0)
                {
                    char c = (char)('a' + random.Next(26));
                    temporaryPassword += c;
                    tempMinCharsVariable--;
                }
            }

            if (temporaryPassword.Length > maxCharsVariable)
            {
                temporaryPassword = stripChars(temporaryPassword, minCharsVariable, maxCharsVariable);
            }

            password += temporaryPassword;
            return password;
        }

        private string stripChars(string password, int min, int max)
        {
            string result = "";
            int size = password.Length;
            bool[] chars = new bool[size];
            Random random = new Random(); 
            int NofCharsReduce = size - random.Next(min, max+1);

            while (NofCharsReduce > 0) 
            {
                int index = random.Next(size);

                if (password[index] >= 'a'  &&  password[index] <= 'z'  &&  !chars[index])
                {
                    chars[index] = true;
                    NofCharsReduce--;
                }
            }

            for (int i=0; i<size; i++)
            {
                if (chars[i])
                {
                    continue;
                }

                result += password[i];
            }

            return result;
        }

        private void Clear()
        {
            minChars.Text = "";
            upperCase.Text = "";
            specialChars.Text = "";
            maxChars.Text = "";
        }
    }
}
