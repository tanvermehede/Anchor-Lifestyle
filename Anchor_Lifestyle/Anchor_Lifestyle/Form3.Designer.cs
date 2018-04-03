namespace Anchor_Lifestyle
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.lstInvoiceNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDiscountPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPerProductDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.txtDiscountPrice = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtTotalRate = new System.Windows.Forms.TextBox();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblTotalQuantaty = new System.Windows.Forms.Label();
            this.lblTotalRate = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountPrice = new System.Windows.Forms.Label();
            this.txtTotalQuantaty = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCustomDate = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDate1 = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblInvoiceOrDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDate2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(25, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(849, 461);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstInvoiceNo,
            this.lstDate,
            this.lstProductName,
            this.lstQuantity,
            this.lstRate,
            this.lstDiscountPercent,
            this.lstPerProductDiscount,
            this.lstPrice});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HoverSelection = true;
            this.listView.Location = new System.Drawing.Point(3, 28);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(843, 405);
            this.listView.TabIndex = 50;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // lstInvoiceNo
            // 
            this.lstInvoiceNo.Text = "Invoice No";
            // 
            // lstDate
            // 
            this.lstDate.Text = "Date";
            this.lstDate.Width = 82;
            // 
            // lstProductName
            // 
            this.lstProductName.Text = "Product Name";
            this.lstProductName.Width = 230;
            // 
            // lstQuantity
            // 
            this.lstQuantity.Text = "Quantity";
            this.lstQuantity.Width = 95;
            // 
            // lstRate
            // 
            this.lstRate.Text = "Rate";
            this.lstRate.Width = 94;
            // 
            // lstDiscountPercent
            // 
            this.lstDiscountPercent.Text = "Discount Percent";
            this.lstDiscountPercent.Width = 100;
            // 
            // lstPerProductDiscount
            // 
            this.lstPerProductDiscount.Text = "Discount Price";
            this.lstPerProductDiscount.Width = 98;
            // 
            // lstPrice
            // 
            this.lstPrice.Text = "Price";
            this.lstPrice.Width = 79;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 10;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Controls.Add(this.txtNetAmount, 9, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtDiscountPrice, 7, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtDiscountPercent, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtTotalRate, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblNetAmount, 8, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblTotalQuantaty, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblTotalRate, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblDiscountPercent, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblDiscountPrice, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtTotalQuantaty, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 436);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(849, 25);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNetAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetAmount.Enabled = false;
            this.txtNetAmount.Location = new System.Drawing.Point(759, 3);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(87, 20);
            this.txtNetAmount.TabIndex = 0;
            // 
            // txtDiscountPrice
            // 
            this.txtDiscountPrice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDiscountPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscountPrice.Enabled = false;
            this.txtDiscountPrice.Location = new System.Drawing.Point(591, 3);
            this.txtDiscountPrice.Name = "txtDiscountPrice";
            this.txtDiscountPrice.Size = new System.Drawing.Size(78, 20);
            this.txtDiscountPrice.TabIndex = 1;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDiscountPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscountPercent.Enabled = false;
            this.txtDiscountPercent.Location = new System.Drawing.Point(423, 3);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(78, 20);
            this.txtDiscountPercent.TabIndex = 2;
            // 
            // txtTotalRate
            // 
            this.txtTotalRate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotalRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalRate.Enabled = false;
            this.txtTotalRate.Location = new System.Drawing.Point(255, 3);
            this.txtTotalRate.Name = "txtTotalRate";
            this.txtTotalRate.Size = new System.Drawing.Size(78, 20);
            this.txtTotalRate.TabIndex = 3;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Location = new System.Drawing.Point(687, 6);
            this.lblNetAmount.Margin = new System.Windows.Forms.Padding(3);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(66, 13);
            this.lblNetAmount.TabIndex = 4;
            this.lblNetAmount.Text = "Net Amount:";
            this.lblNetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalQuantaty
            // 
            this.lblTotalQuantaty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalQuantaty.AutoSize = true;
            this.lblTotalQuantaty.Location = new System.Drawing.Point(8, 6);
            this.lblTotalQuantaty.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalQuantaty.Name = "lblTotalQuantaty";
            this.lblTotalQuantaty.Size = new System.Drawing.Size(76, 13);
            this.lblTotalQuantaty.TabIndex = 5;
            this.lblTotalQuantaty.Text = "Total Quantity:";
            this.lblTotalQuantaty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalRate
            // 
            this.lblTotalRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalRate.AutoSize = true;
            this.lblTotalRate.Location = new System.Drawing.Point(189, 6);
            this.lblTotalRate.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalRate.Name = "lblTotalRate";
            this.lblTotalRate.Size = new System.Drawing.Size(60, 13);
            this.lblTotalRate.TabIndex = 6;
            this.lblTotalRate.Text = "Total Rate:";
            this.lblTotalRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(368, 3);
            this.lblDiscountPercent.Margin = new System.Windows.Forms.Padding(3);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(49, 19);
            this.lblDiscountPercent.TabIndex = 7;
            this.lblDiscountPercent.Text = "Discount Percent:";
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountPrice
            // 
            this.lblDiscountPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDiscountPrice.AutoSize = true;
            this.lblDiscountPrice.Location = new System.Drawing.Point(536, 3);
            this.lblDiscountPrice.Margin = new System.Windows.Forms.Padding(3);
            this.lblDiscountPrice.Name = "lblDiscountPrice";
            this.lblDiscountPrice.Size = new System.Drawing.Size(49, 19);
            this.lblDiscountPrice.TabIndex = 8;
            this.lblDiscountPrice.Text = "Discount Price:";
            this.lblDiscountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalQuantaty
            // 
            this.txtTotalQuantaty.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotalQuantaty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalQuantaty.Enabled = false;
            this.txtTotalQuantaty.Location = new System.Drawing.Point(87, 3);
            this.txtTotalQuantaty.Name = "txtTotalQuantaty";
            this.txtTotalQuantaty.Size = new System.Drawing.Size(78, 20);
            this.txtTotalQuantaty.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.85149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.85149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.81188F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.85149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.960396F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.85149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.910892F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.910892F));
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCustomDate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDate1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTo, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblInvoiceOrDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDate2, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(849, 25);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(771, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 25);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCustomDate
            // 
            this.lblCustomDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCustomDate.AutoSize = true;
            this.lblCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomDate.Location = new System.Drawing.Point(320, 4);
            this.lblCustomDate.Margin = new System.Windows.Forms.Padding(3);
            this.lblCustomDate.Name = "lblCustomDate";
            this.lblCustomDate.Size = new System.Drawing.Size(88, 16);
            this.lblCustomDate.TabIndex = 6;
            this.lblCustomDate.Text = "Custom Date:";
            this.lblCustomDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(129, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtDate1
            // 
            this.txtDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate1.Location = new System.Drawing.Point(414, 3);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(120, 20);
            this.txtDate1.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(541, 4);
            this.lblTo.Margin = new System.Windows.Forms.Padding(3);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 16);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "To";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoiceOrDate
            // 
            this.lblInvoiceOrDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInvoiceOrDate.AutoSize = true;
            this.lblInvoiceOrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceOrDate.Location = new System.Drawing.Point(22, 4);
            this.lblInvoiceOrDate.Name = "lblInvoiceOrDate";
            this.lblInvoiceOrDate.Size = new System.Drawing.Size(101, 16);
            this.lblInvoiceOrDate.TabIndex = 9;
            this.lblInvoiceOrDate.Text = "Invoice or Date:";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(696, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDate2
            // 
            this.txtDate2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate2.Location = new System.Drawing.Point(573, 3);
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(120, 20);
            this.txtDate2.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(915, 550);
            this.Name = "Form3";
            this.Text = "Anchor Lifestyle";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.TextBox txtDiscountPrice;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtTotalRate;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblTotalQuantaty;
        private System.Windows.Forms.Label lblTotalRate;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label lblDiscountPrice;
        private System.Windows.Forms.TextBox txtTotalQuantaty;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader lstInvoiceNo;
        private System.Windows.Forms.ColumnHeader lstDate;
        private System.Windows.Forms.ColumnHeader lstProductName;
        private System.Windows.Forms.ColumnHeader lstQuantity;
        private System.Windows.Forms.ColumnHeader lstRate;
        private System.Windows.Forms.ColumnHeader lstDiscountPercent;
        private System.Windows.Forms.ColumnHeader lstPerProductDiscount;
        private System.Windows.Forms.ColumnHeader lstPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblCustomDate;
        private System.Windows.Forms.TextBox txtDate1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblInvoiceOrDate;
        private System.Windows.Forms.TextBox txtDate2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}