namespace APPmobi
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label13 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(487, 40);
            label1.TabIndex = 4;
            label1.Text = "Mobile Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(200, 58);
            label2.Name = "label2";
            label2.Size = new Size(378, 40);
            label2.TabIndex = 5;
            label2.Text = "Management Mobiles";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepPink;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(238, 350);
            button2.Name = "button2";
            button2.Size = new Size(159, 43);
            button2.TabIndex = 11;
            button2.Text = "Accessories";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepPink;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(436, 350);
            button1.Name = "button1";
            button1.Size = new Size(159, 43);
            button1.TabIndex = 12;
            button1.Text = "Selling";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepPink;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(41, 350);
            button3.Name = "button3";
            button3.Size = new Size(164, 43);
            button3.TabIndex = 13;
            button3.Text = "Mobiles";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(729, 21);
            label13.Name = "label13";
            label13.Size = new Size(40, 40);
            label13.TabIndex = 40;
            label13.Text = "X";
            label13.Click += label13_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepPink;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(632, 350);
            button4.Name = "button4";
            button4.Size = new Size(159, 43);
            button4.TabIndex = 41;
            button4.Text = "Statistics";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(837, 450);
            Controls.Add(button4);
            Controls.Add(label13);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label13;
        private Button button4;
    }
}