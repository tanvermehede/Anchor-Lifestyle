using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Anchor_Lifestyle
{
    public partial class Form3 : Form
    {
        static string connString = "Host=localhost;Username=postgres;Password=151351090;Database=Anchor_Lifestyle";
        NpgsqlConnection con = new NpgsqlConnection(connString);
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string qry = "select * from sellproductlist where todaydate between '" + txtDate1.Text + "' and '" + txtDate2.Text + "'or invoiceno= '" + txtID.Text + "'or todaydate= '" + txtID.Text + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(qry, con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lv.SubItems.Add(dr[4].ToString());
                    lv.SubItems.Add(dr[5].ToString());
                    lv.SubItems.Add(dr[6].ToString());
                    lv.SubItems.Add(dr[7].ToString());
                    listView.Items.Add(lv);
                }
                con.Close();
                dr.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                double totalQuantity = 0;
                double totalRate = 0;
                double discountPercent = 0;
                double discountPrice = 0;
                double netAmount = 0;

                foreach (ListViewItem lstItem in listView.Items)
                {
                    totalQuantity += Convert.ToDouble(lstItem.SubItems[3].Text);
                    totalRate += Convert.ToDouble(lstItem.SubItems[4].Text) * Convert.ToDouble(lstItem.SubItems[3].Text);
                    discountPercent += Convert.ToDouble(lstItem.SubItems[5].Text);
                    discountPrice += Convert.ToDouble(lstItem.SubItems[6].Text);
                    netAmount += Convert.ToDouble(lstItem.SubItems[7].Text);
                }
                txtTotalQuantaty.Text = Convert.ToString(totalQuantity);
                txtTotalRate.Text = Convert.ToString(totalRate);
                txtDiscountPercent.Text = Convert.ToString(discountPercent);
                txtDiscountPrice.Text = Convert.ToString(discountPrice);
                txtNetAmount.Text = Convert.ToString(netAmount);
            }
            catch (Exception)
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDate2.Clear();
            txtDate1.Clear();
            txtID.Clear();
            txtTotalQuantaty.Clear();
            txtTotalRate.Clear();
            txtDiscountPercent.Clear();
            txtDiscountPrice.Clear();
            txtNetAmount.Clear();
            listView.Items.Clear();
        }
    }
}
