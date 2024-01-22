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
using System.Collections;


namespace APPmobi
{
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FPTSHOP\OneDrive\Documents\MobiSoftDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String query = "select Mbrand,MModel,Mprice from MobileTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateAccess()
        {
            Con.Open();
            String query = "select Abrand,AModel,Aprice from AccessorieTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AccessorieDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void insertbill()
        {
            if (Billdtb.Text == "" || ClientNametb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int amount = Convert.ToInt32(Amtlbl.Text);
                try
                {
                    Con.Open();
                    String sql = "insert into BillTbl values('" + Billdtb.Text + "','" + ClientNametb.Text + "'," + amount + ")";

                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();


                    Con.Close();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        int n = 0, Grdtotal = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Enter The Quanity");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BILLDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProductTb.Text;
                newRow.Cells[2].Value = PriceTb.Text;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = total;
                BILLDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = "" + Grdtotal;
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Selling_Load(object sender, EventArgs e)
        {
            populate();
            populateAccess();
            Sum();
        }
        private void Sum()
        {
            string query = "select sum(Amt) from BillTbl";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            /*Sellamtbl.Text = dt.Rows[0][0].ToString();*/
            Con.Close();
        }
        private void MobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductTb.Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString() + MobileDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void AccessorieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductTb.Text = AccessorieDGV.SelectedRows[0].Cells[0].Value.ToString() + AccessorieDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = AccessorieDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MOBISOFT", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(95, 15));
            e.Graphics.DrawString("ID PRODUCT PRICE TOTAL ", new Font("Century Gothic ", 12, FontStyle.Bold), Brushes.Red, new Point(26, 40));

            foreach (DataGridViewRow row in BILLDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(200, pos));

                pos = pos + 20;
            }

            e.Graphics.DrawString("Grand ToTal : Rs" + Grdtotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("********MobiSoft********", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            /*BILLDGV.Rows.Clear();
            BILLDGV.Refresh();*/
            pos = 100;
            Grdtotal = 0;
            n = 0;
            insertbill();
            Sum();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 258, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Sellamtbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Billdtb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ClientNametb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Billdtb.Text == "")
            {
                MessageBox.Show("Enter The Bill to be Deleted");

            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "delete from BillTbl where BillId=" + Billdtb.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Deleted");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {

                }
            }
        }
    }
}
