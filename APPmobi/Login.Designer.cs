namespace APPmobi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UidTb = new MaskedTextBox();
            PassTb = new MaskedTextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(52, 46);
            label1.Name = "label1";
            label1.Size = new Size(317, 40);
            label1.TabIndex = 3;
            label1.Text = "Mobile Shop Khoa";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UidTb
            // 
            UidTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UidTb.ForeColor = Color.Fuchsia;
            UidTb.Location = new Point(147, 216);
            UidTb.Name = "UidTb";
            UidTb.Size = new Size(237, 32);
            UidTb.TabIndex = 5;
            UidTb.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // PassTb
            // 
            PassTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassTb.ForeColor = Color.Fuchsia;
            PassTb.Location = new Point(147, 274);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(237, 32);
            PassTb.TabIndex = 6;
            PassTb.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(111, 332);
            button1.Name = "button1";
            button1.Size = new Size(124, 43);
            button1.TabIndex = 7;
            button1.TabStop = false;
            button1.Text = "Login";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 216);
            label2.Name = "label2";
            label2.Size = new Size(129, 27);
            label2.TabIndex = 8;
            label2.Text = "Tài khoản :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 274);
            label3.Name = "label3";
            label3.Size = new Size(123, 27);
            label3.TabIndex = 9;
            label3.Text = "Mật khẩu :";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(111, 402);
            button2.Name = "button2";
            button2.Size = new Size(124, 39);
            button2.TabIndex = 10;
            button2.Text = "Sign up";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(360, 9);
            label13.Name = "label13";
            label13.Size = new Size(40, 40);
            label13.TabIndex = 41;
            label13.Text = "X";
            label13.Click += label13_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(412, 465);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(PassTb);
            Controls.Add(UidTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox UidTb;
        private MaskedTextBox PassTb;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label13;
    }
}