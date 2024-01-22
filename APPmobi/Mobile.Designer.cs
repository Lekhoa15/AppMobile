namespace APPmobi
{
    partial class Mobile
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
            Mobidtb = new MaskedTextBox();
            modeletb = new MaskedTextBox();
            brandtb = new MaskedTextBox();
            pricetb = new MaskedTextBox();
            stocktb = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ramcb = new ComboBox();
            label10 = new Label();
            romcb = new ComboBox();
            label11 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            MobileDGV = new DataGridView();
            label12 = new Label();
            cameratb = new MaskedTextBox();
            label13 = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MobileDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(487, 40);
            label1.TabIndex = 3;
            label1.Text = "Mobile Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(314, 64);
            label2.Name = "label2";
            label2.Size = new Size(378, 40);
            label2.TabIndex = 4;
            label2.Text = "Management Mobiles";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1349, 10);
            label3.Name = "label3";
            label3.Size = new Size(40, 40);
            label3.TabIndex = 5;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(37, 141);
            label4.Name = "label4";
            label4.Size = new Size(49, 40);
            label4.TabIndex = 6;
            label4.Text = "Id";
            // 
            // Mobidtb
            // 
            Mobidtb.BackColor = SystemColors.Control;
            Mobidtb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Mobidtb.ForeColor = SystemColors.ActiveCaptionText;
            Mobidtb.Location = new Point(143, 152);
            Mobidtb.Name = "Mobidtb";
            Mobidtb.Size = new Size(189, 32);
            Mobidtb.TabIndex = 7;
            // 
            // modeletb
            // 
            modeletb.BackColor = SystemColors.Control;
            modeletb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modeletb.ForeColor = SystemColors.ActiveCaptionText;
            modeletb.Location = new Point(163, 313);
            modeletb.Name = "modeletb";
            modeletb.Size = new Size(257, 32);
            modeletb.TabIndex = 8;
            modeletb.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // brandtb
            // 
            brandtb.BackColor = SystemColors.Control;
            brandtb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            brandtb.ForeColor = SystemColors.ActiveCaptionText;
            brandtb.Location = new Point(143, 221);
            brandtb.Name = "brandtb";
            brandtb.Size = new Size(189, 32);
            brandtb.TabIndex = 9;
            brandtb.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // pricetb
            // 
            pricetb.BackColor = SystemColors.Control;
            pricetb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pricetb.ForeColor = SystemColors.ActiveCaptionText;
            pricetb.Location = new Point(741, 210);
            pricetb.Name = "pricetb";
            pricetb.Size = new Size(234, 32);
            pricetb.TabIndex = 10;
            pricetb.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // stocktb
            // 
            stocktb.BackColor = SystemColors.Control;
            stocktb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stocktb.ForeColor = SystemColors.ActiveCaptionText;
            stocktb.Location = new Point(741, 152);
            stocktb.Name = "stocktb";
            stocktb.Size = new Size(234, 32);
            stocktb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(12, 210);
            label5.Name = "label5";
            label5.Size = new Size(112, 40);
            label5.TabIndex = 13;
            label5.Text = "Brand";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(12, 305);
            label6.Name = "label6";
            label6.Size = new Size(144, 40);
            label6.TabIndex = 14;
            label6.Text = "Modele";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(500, 210);
            label7.Name = "label7";
            label7.Size = new Size(99, 40);
            label7.TabIndex = 15;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(500, 149);
            label8.Name = "label8";
            label8.Size = new Size(109, 40);
            label8.TabIndex = 16;
            label8.Text = "Stock";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(498, 259);
            label9.Name = "label9";
            label9.Size = new Size(194, 40);
            label9.TabIndex = 17;
            label9.Text = "RAM In Gb";
            label9.Click += label9_Click;
            // 
            // ramcb
            // 
            ramcb.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ramcb.FormattingEnabled = true;
            ramcb.Items.AddRange(new object[] { "1", "2", "4", "6", "8" });
            ramcb.Location = new Point(741, 259);
            ramcb.Name = "ramcb";
            ramcb.Size = new Size(234, 47);
            ramcb.TabIndex = 19;
            ramcb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(498, 343);
            label10.Name = "label10";
            label10.Size = new Size(198, 40);
            label10.TabIndex = 20;
            label10.Text = "ROM In Gb";
            // 
            // romcb
            // 
            romcb.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            romcb.FormattingEnabled = true;
            romcb.Items.AddRange(new object[] { "8", "16", "32", "64", "128", "256" });
            romcb.Location = new Point(741, 343);
            romcb.Name = "romcb";
            romcb.Size = new Size(234, 47);
            romcb.TabIndex = 21;
            romcb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(417, 11);
            label11.Name = "label11";
            label11.Size = new Size(247, 40);
            label11.TabIndex = 22;
            label11.Text = "Mobiles Stock";
            label11.Click += label11_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepPink;
            panel1.Controls.Add(label11);
            panel1.Location = new Point(1, 521);
            panel1.Name = "panel1";
            panel1.Size = new Size(1403, 60);
            panel1.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(129, 472);
            button1.Name = "button1";
            button1.Size = new Size(164, 43);
            button1.TabIndex = 23;
            button1.TabStop = false;
            button1.Text = "Add";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(333, 472);
            button2.Name = "button2";
            button2.Size = new Size(164, 43);
            button2.TabIndex = 25;
            button2.TabStop = false;
            button2.Text = "Update";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(544, 472);
            button3.Name = "button3";
            button3.Size = new Size(164, 43);
            button3.TabIndex = 26;
            button3.TabStop = false;
            button3.Text = "Delete";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(714, 472);
            button4.Name = "button4";
            button4.Size = new Size(164, 43);
            button4.TabIndex = 27;
            button4.TabStop = false;
            button4.Text = "Clean";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // MobileDGV
            // 
            MobileDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MobileDGV.Location = new Point(1, 575);
            MobileDGV.Name = "MobileDGV";
            MobileDGV.RowHeadersWidth = 51;
            MobileDGV.RowTemplate.Height = 29;
            MobileDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MobileDGV.Size = new Size(1055, 334);
            MobileDGV.TabIndex = 28;
            MobileDGV.CellContentClick += MobileDGV_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Crimson;
            label12.Location = new Point(288, 407);
            label12.Name = "label12";
            label12.Size = new Size(253, 40);
            label12.TabIndex = 30;
            label12.Text = "Camera In MP";
            // 
            // cameratb
            // 
            cameratb.BackColor = SystemColors.Control;
            cameratb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cameratb.ForeColor = SystemColors.ActiveCaptionText;
            cameratb.Location = new Point(569, 415);
            cameratb.Name = "cameratb";
            cameratb.Size = new Size(234, 32);
            cameratb.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(974, 21);
            label13.Name = "label13";
            label13.Size = new Size(40, 40);
            label13.TabIndex = 31;
            label13.Text = "X";
            label13.Click += label13_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(435, 915);
            button5.Name = "button5";
            button5.Size = new Size(164, 43);
            button5.TabIndex = 32;
            button5.TabStop = false;
            button5.Text = "Back";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Mobile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1053, 960);
            Controls.Add(button5);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(cameratb);
            Controls.Add(MobileDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(romcb);
            Controls.Add(label10);
            Controls.Add(ramcb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(stocktb);
            Controls.Add(pricetb);
            Controls.Add(brandtb);
            Controls.Add(modeletb);
            Controls.Add(Mobidtb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            ForeColor = Color.SeaGreen;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mobile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mobile";
            Load += Mobile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MobileDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox Mobidtb;
        private MaskedTextBox modeletb;
        private MaskedTextBox brandtb;
        private MaskedTextBox pricetb;
        private MaskedTextBox stocktb;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox ramcb;
        private Label label10;
        private ComboBox romcb;
        private Label label11;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView MobileDGV;
        private Label label12;
        private MaskedTextBox cameratb;
        private Label label13;
        private Button button5;
    }
}