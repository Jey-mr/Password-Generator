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
            minChars = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            upperCase = new Label();
            textBox3 = new TextBox();
            specialChars = new Label();
            password = new Button();
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
            label1.Location = new Point(235, 276);
            label1.Name = "label1";
            label1.Size = new Size(359, 42);
            label1.TabIndex = 1;
            label1.Text = "Enter the constraints:";
            // 
            // minChars
            // 
            minChars.AutoSize = true;
            minChars.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minChars.Location = new Point(325, 368);
            minChars.Name = "minChars";
            minChars.Size = new Size(172, 26);
            minChars.TabIndex = 2;
            minChars.Text = "Min no. of chars:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(575, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(575, 434);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 5;
            // 
            // upperCase
            // 
            upperCase.AutoSize = true;
            upperCase.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upperCase.Location = new Point(314, 437);
            upperCase.Name = "upperCase";
            upperCase.Size = new Size(183, 26);
            upperCase.TabIndex = 4;
            upperCase.Text = "No. of upper case:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(575, 500);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 7;
            // 
            // specialChars
            // 
            specialChars.AutoSize = true;
            specialChars.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialChars.Location = new Point(295, 503);
            specialChars.Name = "specialChars";
            specialChars.Size = new Size(202, 26);
            specialChars.TabIndex = 6;
            specialChars.Text = "No. of special chars:";
            // 
            // password
            // 
            password.BackColor = Color.Blue;
            password.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.White;
            password.Location = new Point(413, 584);
            password.Name = "password";
            password.Size = new Size(227, 46);
            password.TabIndex = 8;
            password.Text = "Get Password";
            password.UseVisualStyleBackColor = false;
            password.Click += password_Click;
            // 
            // PasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 752);
            Controls.Add(password);
            Controls.Add(textBox3);
            Controls.Add(specialChars);
            Controls.Add(textBox2);
            Controls.Add(upperCase);
            Controls.Add(textBox1);
            Controls.Add(minChars);
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
        private Label minChars;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label upperCase;
        private TextBox textBox3;
        private Label specialChars;
        private Button password;
    }
}
