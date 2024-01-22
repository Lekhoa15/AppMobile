namespace APPmobi
{
    partial class Signup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 23);
            label1.Name = "label1";
            label1.Size = new Size(208, 38);
            label1.TabIndex = 0;
            label1.Text = "Sigun Up Staff";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 96);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 147);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(86, 196);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(86, 243);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(86, 313);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(235, 411);
            button1.Name = "button1";
            button1.Size = new Size(293, 51);
            button1.TabIndex = 6;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(323, 27);
            textBox3.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(267, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(318, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 313);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 27);
            textBox4.TabIndex = 11;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(300, 489);
            button5.Name = "button5";
            button5.Size = new Size(164, 43);
            button5.TabIndex = 33;
            button5.TabStop = false;
            button5.Text = "Back";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 553);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Button button5;
    }
}