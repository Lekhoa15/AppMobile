namespace APPmobi
{
    partial class Selling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ProductTb = new MaskedTextBox();
            PriceTb = new MaskedTextBox();
            MobileDGV = new DataGridView();
            AccessorieDGV = new DataGridView();
            button1 = new Button();
            label8 = new Label();
            QtyTb = new MaskedTextBox();
            label9 = new Label();
            label13 = new Label();
            BILLDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            Amtlbl = new Label();
            label10 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button5 = new Button();
            ClientNametb = new MaskedTextBox();
            label11 = new Label();
            label4 = new Label();
            Billdtb = new MaskedTextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)MobileDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccessorieDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BILLDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(482, 9);
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
            label2.Location = new Point(651, 49);
            label2.Name = "label2";
            label2.Size = new Size(123, 40);
            label2.TabIndex = 5;
            label2.Text = "Selling";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(47, 223);
            label3.Name = "label3";
            label3.Size = new Size(143, 40);
            label3.TabIndex = 20;
            label3.Text = "Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(47, 300);
            label5.Name = "label5";
            label5.Size = new Size(99, 40);
            label5.TabIndex = 21;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(629, 110);
            label6.Name = "label6";
            label6.Size = new Size(145, 40);
            label6.TabIndex = 22;
            label6.Text = "Mobiles";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(1088, 97);
            label7.Name = "label7";
            label7.Size = new Size(216, 40);
            label7.TabIndex = 23;
            label7.Text = "Accessories";
            // 
            // ProductTb
            // 
            ProductTb.BackColor = SystemColors.Control;
            ProductTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductTb.ForeColor = SystemColors.ActiveCaptionText;
            ProductTb.Location = new Point(196, 231);
            ProductTb.Name = "ProductTb";
            ProductTb.Size = new Size(232, 32);
            ProductTb.TabIndex = 25;
            // 
            // PriceTb
            // 
            PriceTb.BackColor = SystemColors.Control;
            PriceTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.ForeColor = SystemColors.ActiveCaptionText;
            PriceTb.Location = new Point(196, 308);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(232, 32);
            PriceTb.TabIndex = 26;
            // 
            // MobileDGV
            // 
            MobileDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MobileDGV.Location = new Point(484, 153);
            MobileDGV.Name = "MobileDGV";
            MobileDGV.RowHeadersWidth = 51;
            MobileDGV.RowTemplate.Height = 29;
            MobileDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MobileDGV.Size = new Size(430, 308);
            MobileDGV.TabIndex = 29;
            MobileDGV.CellContentClick += MobileDGV_CellContentClick;
            // 
            // AccessorieDGV
            // 
            AccessorieDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccessorieDGV.Location = new Point(991, 153);
            AccessorieDGV.Name = "AccessorieDGV";
            AccessorieDGV.RowHeadersWidth = 51;
            AccessorieDGV.RowTemplate.Height = 29;
            AccessorieDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AccessorieDGV.Size = new Size(415, 308);
            AccessorieDGV.TabIndex = 34;
            AccessorieDGV.CellContentClick += AccessorieDGV_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(63, 438);
            button1.Name = "button1";
            button1.Size = new Size(164, 43);
            button1.TabIndex = 35;
            button1.TabStop = false;
            button1.Text = "Add To Bill";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(34, 374);
            label8.Name = "label8";
            label8.Size = new Size(156, 40);
            label8.TabIndex = 36;
            label8.Text = "Quantity";
            // 
            // QtyTb
            // 
            QtyTb.BackColor = SystemColors.Control;
            QtyTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.ForeColor = SystemColors.ActiveCaptionText;
            QtyTb.Location = new Point(196, 382);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(232, 32);
            QtyTb.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(805, 502);
            label9.Name = "label9";
            label9.Size = new Size(61, 40);
            label9.TabIndex = 38;
            label9.Text = "Bill";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(1366, 26);
            label13.Name = "label13";
            label13.Size = new Size(40, 40);
            label13.TabIndex = 39;
            label13.Text = "X";
            label13.Click += label13_Click;
            // 
            // BILLDGV
            // 
            BILLDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BILLDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BILLDGV.Location = new Point(482, 555);
            BILLDGV.Name = "BILLDGV";
            BILLDGV.RowHeadersWidth = 51;
            BILLDGV.RowTemplate.Height = 29;
            BILLDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BILLDGV.Size = new Size(668, 380);
            BILLDGV.TabIndex = 40;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Product";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepPink;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1166, 747);
            button2.Name = "button2";
            button2.Size = new Size(164, 44);
            button2.TabIndex = 41;
            button2.TabStop = false;
            button2.Text = "Print";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Amtlbl
            // 
            Amtlbl.AutoSize = true;
            Amtlbl.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Amtlbl.ForeColor = Color.Crimson;
            Amtlbl.Location = new Point(1197, 694);
            Amtlbl.Name = "Amtlbl";
            Amtlbl.Size = new Size(146, 40);
            Amtlbl.TabIndex = 42;
            Amtlbl.Text = "Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(1157, 694);
            label10.Name = "label10";
            label10.Size = new Size(52, 40);
            label10.TabIndex = 43;
            label10.Text = "Rs";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1166, 826);
            button5.Name = "button5";
            button5.Size = new Size(164, 43);
            button5.TabIndex = 44;
            button5.TabStop = false;
            button5.Text = "Back";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ClientNametb
            // 
            ClientNametb.BackColor = SystemColors.Control;
            ClientNametb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientNametb.ForeColor = SystemColors.ActiveCaptionText;
            ClientNametb.Location = new Point(196, 105);
            ClientNametb.Name = "ClientNametb";
            ClientNametb.Size = new Size(232, 32);
            ClientNametb.TabIndex = 46;
            ClientNametb.MaskInputRejected += ClientNametb_MaskInputRejected;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(47, 97);
            label11.Name = "label11";
            label11.Size = new Size(112, 40);
            label11.TabIndex = 45;
            label11.Text = "Client";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(47, 167);
            label4.Name = "label4";
            label4.Size = new Size(93, 40);
            label4.TabIndex = 48;
            label4.Text = "BillId";
            // 
            // Billdtb
            // 
            Billdtb.BackColor = SystemColors.Control;
            Billdtb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Billdtb.ForeColor = SystemColors.ActiveCaptionText;
            Billdtb.Location = new Point(196, 175);
            Billdtb.Name = "Billdtb";
            Billdtb.Size = new Size(232, 32);
            Billdtb.TabIndex = 49;
            Billdtb.MaskInputRejected += Billdtb_MaskInputRejected;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1166, 892);
            button3.Name = "button3";
            button3.Size = new Size(164, 43);
            button3.TabIndex = 50;
            button3.TabStop = false;
            button3.Text = "Delete";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Selling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1494, 1009);
            Controls.Add(button3);
            Controls.Add(Billdtb);
            Controls.Add(label4);
            Controls.Add(ClientNametb);
            Controls.Add(label11);
            Controls.Add(button5);
            Controls.Add(label10);
            Controls.Add(Amtlbl);
            Controls.Add(button2);
            Controls.Add(BILLDGV);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(QtyTb);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(AccessorieDGV);
            Controls.Add(MobileDGV);
            Controls.Add(PriceTb);
            Controls.Add(ProductTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Selling";
            Text = "Selling";
            Load += Selling_Load;
            ((System.ComponentModel.ISupportInitialize)MobileDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccessorieDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BILLDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox ProductTb;
        private MaskedTextBox PriceTb;
        private DataGridView MobileDGV;
        private DataGridView AccessorieDGV;
        private Button button1;
        private Label label8;
        private MaskedTextBox QtyTb;
        private Label label9;
        private Label label13;
        private DataGridView BILLDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button2;
        private Label Amtlbl;
        private Label label10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button5;
        private MaskedTextBox ClientNametb;
        private Label label11;
        private Label label4;
        private MaskedTextBox Billdtb;
        private Button button3;
    }
}