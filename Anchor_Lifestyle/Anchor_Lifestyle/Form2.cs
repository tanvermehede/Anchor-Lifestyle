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
    public partial class Form2 : Form
    {
        static string connString = "Host=localhost;Username=postgres;Password=151351090;Database=Anchor_Lifestyle";
        NpgsqlConnection con = new NpgsqlConnection(connString);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtICP.Text)) return;
                con.Open();
                string qry = "select * from customerinfo where invoiceno = '" + txtICP.Text + "'or todaydate= '" + txtICP.Text + "'or customername= '" + txtICP.Text + "'or phonenumber= '" + txtICP.Text + "'";
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
                    lv.SubItems.Add(dr[8].ToString());
                    lv.SubItems.Add(dr[9].ToString());
                    lv.SubItems.Add(dr[10].ToString());
                    listView.Items.Add(lv);
                }
                con.Close();
                dr.Close();
            }
            catch (Exception)
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtICP.Clear();
            listView.Items.Clear();
        }
    }
}
