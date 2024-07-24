namespace PasswordGenerator
{
    partial class PasswordSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordSearch));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            urlBox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(354, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(237, 277);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 1;
            label1.Text = "Enter the url:";
            // 
            // urlBox
            // 
            urlBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlBox.Location = new Point(237, 353);
            urlBox.Name = "urlBox";
            urlBox.Size = new Size(312, 34);
            urlBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(600, 353);
            button1.Name = "button1";
            button1.Size = new Size(107, 34);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PasswordSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 670);
            Controls.Add(button1);
            Controls.Add(urlBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PasswordSearch";
            Text = "PasswordSearch";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox urlBox;
        private Button button1;
    }
}