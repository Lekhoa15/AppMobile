using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APPmobi
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }
        void FillChart()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FPTSHOP\OneDrive\Documents\MobiSoftDb.mdf;Integrated Security=True;Connect Timeout=30");

            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MPrice, MRam from MobileTbl", con);
            da.Fill(dt);
            chart1.DataSource = dt;
            con.Close();
            /*chart1.Series.Add("Thongke");*/
            chart1.Series["MPrice"].XValueMember = "MPrice";
            chart1.Series["MPrice"].YValueMembers = "MRam";// Corrected this line
            chart1.Titles.Add("MPrice Ram");
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            FillChart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home tk = new Home();
            tk.Show();
            this.Hide();



        }



        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

    }
}
