namespace APPmobi
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            VBar = new ProgressBar();
            LBar = new ProgressBar();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // VBar
            // 
            VBar.BackColor = Color.Indigo;
            VBar.Location = new Point(105, -2);
            VBar.Name = "VBar";
            VBar.Size = new Size(11, 413);
            VBar.TabIndex = 0;
            VBar.Click += VBar_Click;
            // 
            // LBar
            // 
            LBar.BackColor = Color.Black;
            LBar.Location = new Point(-3, 378);
            LBar.Name = "LBar";
            LBar.Size = new Size(790, 10);
            LBar.TabIndex = 1;
            LBar.Click += progressBar2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 75);
            label1.Name = "label1";
            label1.Size = new Size(315, 40);
            label1.TabIndex = 2;
            label1.Text = "Mobile Shop Khoa";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(273, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(785, 409);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(LBar);
            Controls.Add(VBar);
            ForeColor = Color.Violet;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar VBar;
        private ProgressBar LBar;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}