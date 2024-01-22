namespace APPmobi
{
    partial class Accessories
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Astock = new MaskedTextBox();
            ApriceTb = new MaskedTextBox();
            AbrandTb = new MaskedTextBox();
            AmodelTb = new MaskedTextBox();
            AidTb = new MaskedTextBox();
            label4 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            mobileBindingSource = new BindingSource(components);
            button5 = new Button();
            AccessorieDGV = new DataGridView();
            label11 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)mobileBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccessorieDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(123, -1);
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
            label2.Location = new Point(163, 54);
            label2.Name = "label2";
            label2.Size = new Size(365, 40);
            label2.TabIndex = 5;
            label2.Text = "Manage Accessories";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(636, 25);
            label3.Name = "label3";
            label3.Size = new Size(40, 40);
            label3.TabIndex = 6;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(362, 104);
            label8.Name = "label8";
            label8.Size = new Size(109, 40);
            label8.TabIndex = 27;
            label8.Text = "Stock";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(362, 179);
            label7.Name = "label7";
            label7.Size = new Size(99, 40);
            label7.TabIndex = 26;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(12, 266);
            label6.Name = "label6";
            label6.Size = new Size(144, 40);
            label6.TabIndex = 25;
            label6.Text = "Modele";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(112, 40);
            label5.TabIndex = 24;
            label5.Text = "Brand";
            // 
            // Astock
            // 
            Astock.BackColor = SystemColors.Control;
            Astock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Astock.ForeColor = SystemColors.ActiveCaptionText;
            Astock.Location = new Point(486, 112);
            Astock.Name = "Astock";
            Astock.Size = new Size(164, 32);
            Astock.TabIndex = 23;
            Astock.MaskInputRejected += maskedTextBox4_MaskInputRejected;
            // 
            // ApriceTb
            // 
            ApriceTb.BackColor = SystemColors.Control;
            ApriceTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApriceTb.ForeColor = SystemColors.ActiveCaptionText;
            ApriceTb.Location = new Point(486, 187);
            ApriceTb.Name = "ApriceTb";
            ApriceTb.Size = new Size(148, 32);
            ApriceTb.TabIndex = 22;
            // 
            // AbrandTb
            // 
            AbrandTb.BackColor = SystemColors.Control;
            AbrandTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AbrandTb.ForeColor = SystemColors.ActiveCaptionText;
            AbrandTb.Location = new Point(140, 193);
            AbrandTb.Name = "AbrandTb";
            AbrandTb.Size = new Size(189, 32);
            AbrandTb.TabIndex = 21;
            // 
            // AmodelTb
            // 
            AmodelTb.BackColor = SystemColors.Control;
            AmodelTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmodelTb.ForeColor = SystemColors.ActiveCaptionText;
            AmodelTb.Location = new Point(163, 274);
            AmodelTb.Name = "AmodelTb";
            AmodelTb.Size = new Size(257, 32);
            AmodelTb.TabIndex = 20;
            // 
            // AidTb
            // 
            AidTb.BackColor = SystemColors.Control;
            AidTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AidTb.ForeColor = SystemColors.ActiveCaptionText;
            AidTb.Location = new Point(140, 118);
            AidTb.Name = "AidTb";
            AidTb.Size = new Size(150, 32);
            AidTb.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(49, 40);
            label4.TabIndex = 18;
            label4.Text = "Id";
            label4.Click += label4_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(414, 396);
            button4.Name = "button4";
            button4.Size = new Size(164, 43);
            button4.TabIndex = 31;
            button4.TabStop = false;
            button4.Text = "Clear";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(414, 347);
            button3.Name = "button3";
            button3.Size = new Size(164, 43);
            button3.TabIndex = 30;
            button3.TabStop = false;
            button3.Text = "Delete";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(140, 396);
            button2.Name = "button2";
            button2.Size = new Size(164, 43);
            button2.TabIndex = 29;
            button2.TabStop = false;
            button2.Text = "Update";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(140, 338);
            button1.Name = "button1";
            button1.Size = new Size(164, 43);
            button1.TabIndex = 28;
            button1.TabStop = false;
            button1.Text = "Add";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mobileBindingSource
            // 
            mobileBindingSource.DataSource = typeof(Model.Mobile);
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(245, 794);
            button5.Name = "button5";
            button5.Size = new Size(154, 39);
            button5.TabIndex = 34;
            button5.TabStop = false;
            button5.Text = "Back";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // AccessorieDGV
            // 
            AccessorieDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccessorieDGV.Location = new Point(0, 504);
            AccessorieDGV.Name = "AccessorieDGV";
            AccessorieDGV.RowHeadersWidth = 51;
            AccessorieDGV.RowTemplate.Height = 29;
            AccessorieDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccessorieDGV.Size = new Size(1122, 284);
            AccessorieDGV.TabIndex = 35;
            AccessorieDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(153, 16);
            label11.Name = "label11";
            label11.Size = new Size(318, 40);
            label11.TabIndex = 22;
            label11.Text = "Accessories Stock";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepPink;
            panel1.Controls.Add(label11);
            panel1.Location = new Point(0, 445);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 60);
            panel1.TabIndex = 32;
            // 
            // Accessories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(675, 837);
            Controls.Add(AccessorieDGV);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Astock);
            Controls.Add(ApriceTb);
            Controls.Add(AbrandTb);
            Controls.Add(AmodelTb);
            Controls.Add(AidTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Accessories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accessories";
            Load += Accessories_Load;
            ((System.ComponentModel.ISupportInitialize)mobileBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccessorieDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox Astock;
        private MaskedTextBox ApriceTb;
        private MaskedTextBox AbrandTb;
        private MaskedTextBox AmodelTb;
        private MaskedTextBox AidTb;
        private Label label4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private BindingSource mobileBindingSource;
        private DataGridView AccessorieDGV;
        private Label label11;
        private Panel panel1;
    }
}