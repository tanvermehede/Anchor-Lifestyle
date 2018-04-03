namespace Anchor_Lifestyle
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtICP = new System.Windows.Forms.TextBox();
            this.InvoiceOrDateOrNameOrPhone = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.lstInvoiceNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstBillingAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTotalQuantaty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTotalDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstNetAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPaidAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstReturnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(850, 461);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtICP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.InvoiceOrDateOrNameOrPhone, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(850, 25);
            this.tableLayoutPanel3.TabIndex = 54;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(696, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(772, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtICP
            // 
            this.txtICP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtICP.Location = new System.Drawing.Point(572, 3);
            this.txtICP.Name = "txtICP";
            this.txtICP.Size = new System.Drawing.Size(121, 20);
            this.txtICP.TabIndex = 4;
            // 
            // InvoiceOrDateOrNameOrPhone
            // 
            this.InvoiceOrDateOrNameOrPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InvoiceOrDateOrNameOrPhone.AutoSize = true;
            this.InvoiceOrDateOrNameOrPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceOrDateOrNameOrPhone.Location = new System.Drawing.Point(353, 4);
            this.InvoiceOrDateOrNameOrPhone.Name = "InvoiceOrDateOrNameOrPhone";
            this.InvoiceOrDateOrNameOrPhone.Size = new System.Drawing.Size(213, 16);
            this.InvoiceOrDateOrNameOrPhone.TabIndex = 1;
            this.InvoiceOrDateOrNameOrPhone.Text = "Invoice or Date or Name or Phone:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstInvoiceNo,
            this.lstDate,
            this.lstCustomerName,
            this.lstPhoneNumber,
            this.lstBillingAddress,
            this.lstTotalQuantaty,
            this.lstTotalPrice,
            this.lstTotalDiscount,
            this.lstNetAmount,
            this.lstPaidAmount,
            this.lstReturnAmount});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HoverSelection = true;
            this.listView.Location = new System.Drawing.Point(3, 28);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(844, 430);
            this.listView.TabIndex = 53;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // lstInvoiceNo
            // 
            this.lstInvoiceNo.Text = "Invoice No";
            this.lstInvoiceNo.Width = 65;
            // 
            // lstDate
            // 
            this.lstDate.Text = "Date";
            this.lstDate.Width = 91;
            // 
            // lstCustomerName
            // 
            this.lstCustomerName.Text = "CustomerName";
            this.lstCustomerName.Width = 85;
            // 
            // lstPhoneNumber
            // 
            this.lstPhoneNumber.Text = "Phone Number";
            this.lstPhoneNumber.Width = 87;
            // 
            // lstBillingAddress
            // 
            this.lstBillingAddress.Text = "Billing Address";
            this.lstBillingAddress.Width = 83;
            // 
            // lstTotalQuantaty
            // 
            this.lstTotalQuantaty.Text = "Total Quantaty";
            this.lstTotalQuantaty.Width = 89;
            // 
            // lstTotalPrice
            // 
            this.lstTotalPrice.Text = "Total Price";
            this.lstTotalPrice.Width = 71;
            // 
            // lstTotalDiscount
            // 
            this.lstTotalDiscount.Text = "Total Discount";
            // 
            // lstNetAmount
            // 
            this.lstNetAmount.Text = "Net Amount";
            this.lstNetAmount.Width = 70;
            // 
            // lstPaidAmount
            // 
            this.lstPaidAmount.Text = "Paid Amount";
            this.lstPaidAmount.Width = 78;
            // 
            // lstReturnAmount
            // 
            this.lstReturnAmount.Text = "Return Amount";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(915, 550);
            this.Name = "Form2";
            this.Text = "Anchor Lifestyle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtICP;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader lstInvoiceNo;
        private System.Windows.Forms.ColumnHeader lstDate;
        private System.Windows.Forms.ColumnHeader lstCustomerName;
        private System.Windows.Forms.ColumnHeader lstPhoneNumber;
        private System.Windows.Forms.ColumnHeader lstBillingAddress;
        private System.Windows.Forms.ColumnHeader lstTotalQuantaty;
        private System.Windows.Forms.ColumnHeader lstTotalPrice;
        private System.Windows.Forms.ColumnHeader lstTotalDiscount;
        private System.Windows.Forms.ColumnHeader lstNetAmount;
        private System.Windows.Forms.ColumnHeader lstPaidAmount;
        private System.Windows.Forms.ColumnHeader lstReturnAmount;
        private System.Windows.Forms.Label InvoiceOrDateOrNameOrPhone;
    }
}