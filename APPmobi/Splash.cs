namespace APPmobi
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {


            startpoint += 1;
            VBar.Value = startpoint;
            LBar.Value = startpoint;
            if (LBar.Value == 100)
            {
                VBar.Value = 0;
                LBar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }

        }

        private void VBar_Click(object sender, EventArgs e)
        {

        }
    }
}