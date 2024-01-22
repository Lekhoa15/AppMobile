using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace APPmobi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mobile mob = new Mobile();
            mob.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Accessories acc = new Accessories();
            acc.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Selling sel = new Selling();
            sel.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Thongke tk = new Thongke();
            tk.Show();
            this.Hide();
        }
    }
}
