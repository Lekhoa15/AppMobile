using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace APPmobi
{
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FPTSHOP\OneDrive\Documents\MobiSoftDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String query = "select * from AccessorieTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AccessorieDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "" || AbrandTb.Text == "" || AmodelTb.Text == "" || ApriceTb.Text == "" || Astock.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "insert into AccessorieTbl(ABrand,AModel,AStock,APrice,AId) values( '" + AbrandTb.Text + "' , '" + AmodelTb.Text + "'," + Astock.Text + ", " + ApriceTb.Text + "," + AidTb.Text + ")";
                    /*String sql = "insert into AccessorieTbl values("AidTb.Text + ",'" + AbrandTb.Text + ",'" + AmodelTb.Text + "','" + Astock.Text + "'," + ApriceTb.Text + "," + ApriceTb.Text + ","   ")";*/
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessorie Added Data Successfully");

                    Con.Close();
                    populate();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void Accessories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AidTb.Text = "";
            AbrandTb.Text = "";
            AmodelTb.Text = "";
            ApriceTb.Text = "";
            Astock.Text = "";

        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "")
            {
                MessageBox.Show("Enter The Accessories to be Deleted");

            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from AccessorieTbl where AId=" + AidTb.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessrie Deleted");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AidTb.Text == "" || AbrandTb.Text == "" || AmodelTb.Text == "" || ApriceTb.Text == "" || Astock.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "update AccessorieTbl set Abrand='" + AbrandTb.Text + "', AModel='" + AmodelTb.Text + "', APrice=" + ApriceTb.Text + ", Astock=" + Astock.Text + "where AId=" + AidTb.Text;
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Accessories Updated Data Successfully");

                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AidTb.Text = AccessorieDGV.SelectedRows[0].Cells[0].Value.ToString();
            AbrandTb.Text = AccessorieDGV.SelectedRows[0].Cells[1].Value.ToString();
            AmodelTb.Text = AccessorieDGV.SelectedRows[0].Cells[2].Value.ToString();
            Astock.Text = AccessorieDGV.SelectedRows[0].Cells[3].Value.ToString();
            ApriceTb.Text = AccessorieDGV.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
