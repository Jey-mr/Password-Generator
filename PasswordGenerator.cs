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

        private void password_Click(object sender, EventArgs e)
        {
            string? urlVariable = (url.Text.Length > 0) ? url.Text : null;
            string? userNameVariable = (userName.Text.Length > 0) ? userName.Text : null;
            if (urlVariable == null || userNameVariable == null)
            {
                MessageBox.Show("URL and UserName should not be empty");
            }
            else if (!Uri.IsWellFormedUriString(urlVariable, UriKind.Absolute))
            {
                MessageBox.Show("Enter a valid url!");
            }
            else
            {
                string? generatedPassword = GeneratePassword();
                if (generatedPassword != null)
                {
                    //MessageBox.Show("Generated Password: "+generatedPassword);
                    PasswordStore form = new PasswordStore(urlVariable, userNameVariable, generatedPassword);
                    form.Show();
                }
            }
            Clear();
        }

        private string GeneratePassword()
        {
            int minCharsVariable, upperCaseVariable, specialCharsVariable, maxCharsVariable, randomValue;
            char[] specialCharsArr = { '!', '@', '#', '$', '%', '^', '*' };
            Random random = new Random();

            try
            {
                upperCaseVariable = (upperCase.Text.Length > 0) ? Int32.Parse(upperCase.Text) : 0;
                specialCharsVariable = (specialChars.Text.Length > 0) ? Int32.Parse(specialChars.Text) : 0;
                minCharsVariable = (minChars.Text.Length > 0) ? Int32.Parse(minChars.Text) : upperCaseVariable + specialCharsVariable;
                maxCharsVariable = (maxChars.Text.Length > 0) ? Int32.Parse(maxChars.Text) : minCharsVariable;
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid Constraints");
                return null;
            }

            if (minCharsVariable > maxCharsVariable)
            {
                MessageBox.Show("Min chars must be less than or equal to Max chars");
                return null;
            }

            if (upperCaseVariable + specialCharsVariable > maxCharsVariable)
            {
                MessageBox.Show("Max chars must be greator than or equal to the sum of upper case and special chars");
                return null;
            }

            if (minCharsVariable == 0 && upperCaseVariable == 0 && specialCharsVariable == 0 && maxCharsVariable == 0)
            {
                minCharsVariable = maxCharsVariable = random.Next(8, 16);
            }

            if (upperCaseVariable + specialCharsVariable > minCharsVariable)
            {
                minCharsVariable = upperCaseVariable + specialCharsVariable;
            }

            string password = "";

            while (upperCaseVariable > 0 || specialCharsVariable > 0)
            {
                randomValue = random.Next(3);

                while (randomValue > 0)
                {
                    char c = (char)('a' + random.Next(26));
                    password += c;
                    randomValue--;
                }

                if (random.Next(2) == 0)
                {
                    randomValue = random.Next(upperCaseVariable + 1);

                    while (randomValue > 0)
                    {
                        char c = (char)('A' + random.Next(26));
                        password += c;
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
                        password += c;
                        randomValue--;
                        specialCharsVariable--;
                        //MessageBox.Show("Remaining Special Characters: "+specialCharsVariable);
                    }
                }
            }

            int tempMinCharsVariable = minCharsVariable - password.Length;

            if (tempMinCharsVariable > 0)
            {
                while (tempMinCharsVariable > 0)
                {
                    char c = (char)('a' + random.Next(26));
                    password += c;
                    tempMinCharsVariable--;
                }
            }

            //MessageBox.Show("Unstriped Password: "+password);

            if (password.Length > maxCharsVariable)
            {
                password = stripChars(password, minCharsVariable, maxCharsVariable);
            }

            return password;
        }

        private string stripChars(string password, int min, int max)
        {
            string result = "";
            int size = password.Length;
            bool[] chars = new bool[size];
            Random random = new Random();
            int NofCharsReduce = size - random.Next(min, max + 1);
            HashSet<char> CharSet = [];

            //MessageBox.Show("No of Characters going to reduce: "+NofCharsReduce);

            for (int i=0; i<size; i++)
            {
                chars[i] = true;
            }

            for (int i=0; i<26; i++)
            {
                CharSet.Add((char)('a'+i));
            }

            while (NofCharsReduce > 0)
            {
                int index = random.Next(size);
                char c = password[index];

                if (CharSet.Contains(c) && chars[index])
                {
                    chars[index] = false;
                    NofCharsReduce--;
                }
            }
            
            for (int i = 0; i < size; i++)
            {
                if (chars[i])
                {
                    result += password[i];
                }
            }

            //MessageBox.Show("Length of the result: "+result.Length);

            return result;
        }

        private void Clear()
        {
            minChars.Text = "";
            upperCase.Text = "";
            specialChars.Text = "";
            maxChars.Text = "";
            url.Text = "";
            userName.Text = "";
        }

        private void searchPassword_Click(object sender, EventArgs e)
        {
            PasswordSearch form = new PasswordSearch();
            form.Show();
        }
    }
}
