namespace PasswordGenerator
{
    partial class PasswordStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordStore));
            pictureBox1 = new PictureBox();
            passwordHeadingLabel = new Label();
            password = new Label();
            passwordLabel = new Label();
            ignore = new Button();
            store = new Button();
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
            // passwordHeadingLabel
            // 
            passwordHeadingLabel.AutoSize = true;
            passwordHeadingLabel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordHeadingLabel.Location = new Point(441, 245);
            passwordHeadingLabel.Name = "passwordHeadingLabel";
            passwordHeadingLabel.Size = new Size(174, 26);
            passwordHeadingLabel.TabIndex = 1;
            passwordHeadingLabel.Text = "Your password is";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.Location = new Point(469, 325);
            password.Name = "password";
            password.Size = new Size(0, 38);
            password.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(475, 303);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(90, 35);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "label1";
            // 
            // ignore
            // 
            ignore.BackColor = Color.Red;
            ignore.FlatStyle = FlatStyle.Popup;
            ignore.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ignore.ForeColor = Color.White;
            ignore.Location = new Point(537, 382);
            ignore.Name = "ignore";
            ignore.Size = new Size(94, 29);
            ignore.TabIndex = 4;
            ignore.Text = "Close";
            ignore.UseVisualStyleBackColor = false;
            ignore.Click += ignore_Click;
            // 
            // store
            // 
            store.BackColor = Color.Green;
            store.BackgroundImageLayout = ImageLayout.Zoom;
            store.FlatStyle = FlatStyle.Popup;
            store.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            store.ForeColor = Color.White;
            store.Location = new Point(421, 382);
            store.Name = "store";
            store.Size = new Size(94, 29);
            store.TabIndex = 5;
            store.Text = "Store";
            store.UseVisualStyleBackColor = false;
            store.Click += store_Click;
            // 
            // PasswordStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 739);
            Controls.Add(store);
            Controls.Add(ignore);
            Controls.Add(passwordLabel);
            Controls.Add(password);
            Controls.Add(passwordHeadingLabel);
            Controls.Add(pictureBox1);
            Name = "PasswordStore";
            Text = "PasswordStore";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label passwordHeadingLabel;
        private Label password;
        private Label passwordLabel;
        private Button ignore;
        private Button store;
    }
}