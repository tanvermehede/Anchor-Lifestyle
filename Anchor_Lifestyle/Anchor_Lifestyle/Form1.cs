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
    public partial class Form1 : Form
    {
        static string connString = "Host=localhost;Username=postgres;Password=151351090;Database=Anchor_Lifestyle";
        NpgsqlConnection con = new NpgsqlConnection(connString);

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            invoiceNo();
        }

        private void txtDiscountPrcnt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPrice.Text = (Convert.ToDouble(txtQuantity.Text) * Convert.ToDouble(txtRate.Text)).ToString();
                double orginalprice = Convert.ToDouble(txtPrice.Text);
                double discountprcnt = Convert.ToDouble(txtDiscountPrcnt.Text);
                double discountprice = (orginalprice * discountprcnt) / 100;
                double productprice = orginalprice - discountprice;
                txtPrice.Text = productprice.ToString();
                txtPerProductDiscount.Text = discountprice.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductNo.Text) || string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtRate.Text) || string.IsNullOrEmpty(txtDiscountPrcnt.Text) || string.IsNullOrEmpty(txtPerProductDiscount.Text) || string.IsNullOrEmpty(txtPrice.Text)) return;
                ListViewItem item = new ListViewItem(txtProductNo.Text);
                item.SubItems.Add(txtProductName.Text);
                item.SubItems.Add(txtQuantity.Text);
                item.SubItems.Add(txtRate.Text);
                item.SubItems.Add(txtDiscountPrcnt.Text);
                item.SubItems.Add(txtPerProductDiscount.Text);
                item.SubItems.Add(txtPrice.Text);
                listView.Items.Add(item);
                txtProductNo.Clear();
                txtProductName.Clear();
                txtQuantity.Clear();
                txtRate.Clear();
                txtDiscountPrcnt.Clear();
                txtPrice.Clear();
                txtProductNo.Focus();
            }
            catch (Exception)
            {

            }

            try
            {
                double totalQuantity = 0;
                double totalPrice = 0;
                double netAmount = 0;
                foreach (ListViewItem lstItem in listView.Items)
                {
                    totalQuantity += Convert.ToDouble(lstItem.SubItems[2].Text);
                    totalPrice += Convert.ToDouble(lstItem.SubItems[3].Text) * Convert.ToDouble(lstItem.SubItems[2].Text);
                    netAmount += Convert.ToDouble(lstItem.SubItems[6].Text);
                }
                txtTotalQuantity.Text = Convert.ToString(totalQuantity);
                txtTotalPrice.Text = Convert.ToString(totalPrice);
                txtNetAmount.Text = Convert.ToString(netAmount);
                txtTotalDiscount.Text = (Convert.ToDouble(txtTotalPrice.Text) - Convert.ToDouble(txtNetAmount.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.Items.Count > 0)
                {
                    listView.Items.Remove(listView.SelectedItems[0]);
                }

                double totalQuantity = 0;
                double totalPrice = 0;
                double netAmount = 0;
                foreach (ListViewItem lstItem in listView.Items)
                {
                    totalQuantity += Convert.ToDouble(lstItem.SubItems[2].Text);
                    totalPrice += Convert.ToDouble(lstItem.SubItems[3].Text) * Convert.ToDouble(lstItem.SubItems[2].Text);
                    netAmount += Convert.ToDouble(lstItem.SubItems[6].Text);
                }
                txtTotalQuantity.Text = Convert.ToString(totalQuantity);
                txtTotalPrice.Text = Convert.ToString(totalPrice);
                txtNetAmount.Text = Convert.ToString(netAmount);
                txtTotalDiscount.Text = (Convert.ToDouble(txtTotalPrice.Text) - Convert.ToDouble(txtNetAmount.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listView.Items)
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sellproductlist (invoiceno,todaydate,productname,quantity,rate,discountpercent,discountprice,price)values(@invoiceno,@todaydate,@productname,@quantity,@rate,@discountpercent,@discountprice,@price)", con);
                    cmd.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text);
                    cmd.Parameters.AddWithValue("@todaydate", txtTodayDate.Text);
                    cmd.Parameters.AddWithValue("@productname", item.SubItems[1].Text);
                    cmd.Parameters.AddWithValue("@quantity", item.SubItems[2].Text);
                    cmd.Parameters.AddWithValue("@rate", item.SubItems[3].Text);
                    cmd.Parameters.AddWithValue("@discountpercent", item.SubItems[4].Text);
                    cmd.Parameters.AddWithValue("@discountprice", item.SubItems[5].Text);
                    cmd.Parameters.AddWithValue("@price", item.SubItems[6].Text);
                    cmd.ExecuteReader();
                    con.Close();
                }
            }
            catch (Exception)
            {

            }
            try
            {
                con.Open();
                NpgsqlCommand qry = new NpgsqlCommand("INSERT INTO customerinfo(invoiceno,todaydate,customername,phonenumber,billingaddress,totalquantity,totalprice,totaldiscount,netamount,paidamount,returnamount) VALUES (@invoiceno,@todaydate,@customername,@phonenumber,@billingaddress,@totalquantity,@totalprice,@totaldiscount,@netamount,@paidamount,@returnamount)", con);
                qry.Parameters.AddWithValue("@invoiceno", txtInvoiceNo.Text);
                qry.Parameters.AddWithValue("@todaydate", txtTodayDate.Text);
                qry.Parameters.AddWithValue("@customername", txtCustomerName.Text);
                qry.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
                qry.Parameters.AddWithValue("@billingaddress", txtBillingAddress.Text);
                qry.Parameters.AddWithValue("@totalquantity", txtTotalQuantity.Text);
                qry.Parameters.AddWithValue("@totalprice", txtTotalPrice.Text);
                qry.Parameters.AddWithValue("@totaldiscount", txtTotalDiscount.Text);
                qry.Parameters.AddWithValue("@netamount", txtNetAmount.Text);
                qry.Parameters.AddWithValue("@paidamount", txtPaidAmount.Text);
                qry.Parameters.AddWithValue("@returnamount", txtReturnAmount.Text);
                qry.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

            }
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtBillingAddress.Clear();
            listView.Items.Clear();
            txtTotalQuantity.Clear();
            txtTotalPrice.Clear();
            txtTotalDiscount.Clear();
            txtNetAmount.Clear();
            txtPaidAmount.Clear();
            txtReturnAmount.Clear();
            invoiceNo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtBillingAddress.Clear();
            txtProductNo.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtRate.Clear();
            txtDiscountPrcnt.Clear();
            txtPrice.Clear();
            txtTotalPrice.Clear();
            txtTotalQuantity.Clear();
            txtTotalDiscount.Clear();
            txtNetAmount.Clear();
            txtPaidAmount.Clear();
            txtReturnAmount.Clear();
            listView.Items.Clear();
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtReturnAmount.Text = (Convert.ToDouble(txtNetAmount.Text) - Convert.ToDouble(txtPaidAmount.Text)).ToString();
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTodayDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtTimeNow.Text = DateTime.Now.ToShortTimeString();
        }

        public void invoiceNo()
        {
            try
            {
                con.Open();
                string qry = "select invoiceno from sellproductlist";
                NpgsqlCommand cmd = new NpgsqlCommand(qry, con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtInvoiceNo.Text = dr["invoiceno"].ToString();
                }
                int invoiceNo = int.Parse(txtInvoiceNo.Text);
                invoiceNo = invoiceNo + 1;
                txtInvoiceNo.Text = invoiceNo.ToString();
                con.Close();
                dr.Close();
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}