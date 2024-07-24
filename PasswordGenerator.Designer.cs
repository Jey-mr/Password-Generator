namespace PasswordGenerator
{
    partial class PasswordGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            minCharsLabel = new Label();
            minChars = new TextBox();
            upperCase = new TextBox();
            upperCaseLabel = new Label();
            specialChars = new TextBox();
            specialCharsLabel = new Label();
            password = new Button();
            maxChars = new TextBox();
            maxCharsLabel = new Label();
            url = new TextBox();
            urlLabel = new Label();
            userName = new TextBox();
            label3 = new Label();
            searchPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 256);
            label1.Name = "label1";
            label1.Size = new Size(359, 42);
            label1.TabIndex = 1;
            label1.Text = "Enter the constraints:";
            // 
            // minCharsLabel
            // 
            minCharsLabel.AutoSize = true;
            minCharsLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minCharsLabel.Location = new Point(265, 332);
            minCharsLabel.Name = "minCharsLabel";
            minCharsLabel.Size = new Size(268, 26);
            minCharsLabel.TabIndex = 2;
            minCharsLabel.Text = "Minimum number of chars:";
            // 
            // minChars
            // 
            minChars.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minChars.Location = new Point(593, 329);
            minChars.Name = "minChars";
            minChars.Size = new Size(125, 34);
            minChars.TabIndex = 3;
            // 
            // upperCase
            // 
            upperCase.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upperCase.Location = new Point(593, 384);
            upperCase.Name = "upperCase";
            upperCase.Size = new Size(125, 34);
            upperCase.TabIndex = 5;
            // 
            // upperCaseLabel
            // 
            upperCaseLabel.AutoSize = true;
            upperCaseLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upperCaseLabel.Location = new Point(308, 387);
            upperCaseLabel.Name = "upperCaseLabel";
            upperCaseLabel.Size = new Size(225, 26);
            upperCaseLabel.TabIndex = 4;
            upperCaseLabel.Text = "Number of upper case:";
            // 
            // specialChars
            // 
            specialChars.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialChars.Location = new Point(593, 435);
            specialChars.Name = "specialChars";
            specialChars.Size = new Size(125, 34);
            specialChars.TabIndex = 7;
            // 
            // specialCharsLabel
            // 
            specialCharsLabel.AutoSize = true;
            specialCharsLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialCharsLabel.Location = new Point(289, 438);
            specialCharsLabel.Name = "specialCharsLabel";
            specialCharsLabel.Size = new Size(244, 26);
            specialCharsLabel.TabIndex = 6;
            specialCharsLabel.Text = "Number of special chars:";
            // 
            // password
            // 
            password.BackColor = Color.Blue;
            password.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.White;
            password.Location = new Point(265, 681);
            password.Name = "password";
            password.Size = new Size(227, 46);
            password.TabIndex = 20;
            password.Text = "Get Password";
            password.UseVisualStyleBackColor = false;
            password.Click += password_Click;
            // 
            // maxChars
            // 
            maxChars.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxChars.Location = new Point(593, 489);
            maxChars.Name = "maxChars";
            maxChars.Size = new Size(125, 34);
            maxChars.TabIndex = 9;
            // 
            // maxCharsLabel
            // 
            maxCharsLabel.AutoSize = true;
            maxCharsLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxCharsLabel.Location = new Point(262, 492);
            maxCharsLabel.Name = "maxCharsLabel";
            maxCharsLabel.Size = new Size(271, 26);
            maxCharsLabel.TabIndex = 8;
            maxCharsLabel.Text = "Maximum number of chars:";
            // 
            // url
            // 
            url.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            url.Location = new Point(593, 541);
            url.Name = "url";
            url.Size = new Size(125, 34);
            url.TabIndex = 12;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlLabel.Location = new Point(472, 544);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(61, 26);
            urlLabel.TabIndex = 11;
            urlLabel.Text = "URL:";
            // 
            // userName
            // 
            userName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(593, 593);
            userName.Name = "userName";
            userName.Size = new Size(125, 34);
            userName.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(413, 596);
            label3.Name = "label3";
            label3.Size = new Size(120, 26);
            label3.TabIndex = 13;
            label3.Text = "User Name:";
            // 
            // searchPassword
            // 
            searchPassword.BackColor = Color.Green;
            searchPassword.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPassword.ForeColor = Color.White;
            searchPassword.Location = new Point(511, 681);
            searchPassword.Name = "searchPassword";
            searchPassword.Size = new Size(227, 46);
            searchPassword.TabIndex = 21;
            searchPassword.Text = "Search Password";
            searchPassword.UseVisualStyleBackColor = false;
            searchPassword.Click += searchPassword_Click;
            // 
            // PasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 879);
            Controls.Add(searchPassword);
            Controls.Add(userName);
            Controls.Add(label3);
            Controls.Add(url);
            Controls.Add(urlLabel);
            Controls.Add(maxChars);
            Controls.Add(maxCharsLabel);
            Controls.Add(password);
            Controls.Add(specialChars);
            Controls.Add(specialCharsLabel);
            Controls.Add(upperCase);
            Controls.Add(upperCaseLabel);
            Controls.Add(minChars);
            Controls.Add(minCharsLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PasswordGenerator";
            Text = "PasswordGenerator";
            Load += PasswordGenerator_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label minCharsLabel;
        private TextBox minChars;
        private TextBox upperCase;
        private Label upperCaseLabel;
        private TextBox specialChars;
        private Label specialCharsLabel;
        private Button password;
        private TextBox maxChars;
        private Label maxCharsLabel;
        private TextBox url;
        private Label urlLabel;
        private TextBox userName;
        private Label label3;
        private Button searchPassword;
    }
}
