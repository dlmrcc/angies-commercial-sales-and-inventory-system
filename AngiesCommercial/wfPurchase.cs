using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
namespace AngiesCommercial
{
    public partial class wfPurchase : Form
    {
        public wfPurchase()
        {
            InitializeComponent();
        }
        void vCust()
        {
            wfLogIn.q = "SELECT custid, name `CUSTOMER` FROM cust order by name";
            wfLogIn.vSelect();
            dgCust.DataSource = wfLogIn.t;
            dgCust.Columns[0].Visible = false;
        }
        private void wfPurchase_Load(object sender, EventArgs e)
        {
            vCust();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ph");
            txtQty.Text = "1";
            txtCash.Text = "0";
        }
        double dPrice;
        int iQty;
        DateTime dManuDate, dExpiDate;
        void vSelectItem()
        {
            wfLogIn.q = "SELECT name, price, qty, manudate, expidate FROM product where barcode = '" + txtBarcode.Text + "'";
            wfLogIn.vSelect();
            if (wfLogIn.t.Rows.Count > 0)
            {
                rtItem.Text = wfLogIn.t.Rows[0][0].ToString();
                dPrice = Convert.ToDouble(wfLogIn.t.Rows[0][1]);
                iQty = Convert.ToInt32(wfLogIn.t.Rows[0][2]);
                dManuDate = Convert.ToDateTime(wfLogIn.t.Rows[0][3]);
                dExpiDate = Convert.ToDateTime(wfLogIn.t.Rows[0][4]);
                lbPrice.Text = dPrice.ToString("c");
                lbPrice.Focus();
            }
            else
            {
                MessageBox.Show("Item doesn't exist! Please contact your administrator.", "Unidentified Item");
                txtBarcode.Focus();
            }
        }
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                vSelectItem();
            }
        }
        double dAmount;
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dAmount = Convert.ToDouble(txtQty.Text) * dPrice;
            }
            catch { dAmount = 0; }
            lbAmount.Text = dAmount.ToString("c");
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void bnPurchase_Click(object sender, EventArgs e)
        {
            vPurchase();
        }
        void vOrderedProduct()
        {
            wfLogIn.q = "SELECT s.subid,"
                + " p.name `NAME`,"
                + " s.qty `QTY`,"
                + " s.price `PRICE`,"
                + " s.amount `AMOUNT`"
                + " FROM sub s left join"
                + " (billing b, cust c, product p)"
                + " on (s.billingid = b.billingid and s.barcode = p.barcode and b.custid = c.custid)"
                + " where s.void = 'N' and b.custid = '" + sCustID + "'";
            wfLogIn.vSelect();
            dgOrderList.DataSource = wfLogIn.t;
            dgOrderList.Columns[0].Visible = false;
            dgOrderList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgOrderList.Columns[3].DefaultCellStyle.Format = "c";
            dgOrderList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgOrderList.Columns[4].DefaultCellStyle.Format = "c";
            vTotalAmount();
        }
        void vTotalAmount()
        {
            wfLogIn.q = "SELECT sum(s.qty),"
                + " sum(s.amount) FROM sub"
                + " s left join (billing b, cust c)"
                + " on (b.billingid = s.billingid and c.custid = b.custid)"
                + " where s.void = 'N' and b.custid = '" + sCustID + "'";
            wfLogIn.vSelect();
            try
            {
                dQty = Convert.ToDouble(wfLogIn.t.Rows[0][0]);
                dTotalAmount = Convert.ToDouble(wfLogIn.t.Rows[0][1]);
            }
            catch
            {
                dTotalAmount = 0;
                dQty = 0;
            }
            lbTotalAmount.Text = dTotalAmount.ToString("c");
        }
        double dQty;
        double dTotalAmount;
        void vBillingID()
        {
            wfLogIn.q = "select billingid from billing where custid = '" + sCustID
                + "' and flag = 'N'";
            wfLogIn.vSelect();
            try
            {
                sBillingID = wfLogIn.t.Rows[0][0].ToString();
            }
            catch
            {
                wfLogIn.q = "select count(billingid) from billing where date like '" + DateTime.Now.ToString("yyyy") + "%'";
                wfLogIn.vSelect();
                sBillingID = DateTime.Now.ToString("yyyy-") + (Convert.ToInt32(wfLogIn.t.Rows[0][0]) + 1).ToString("d5");
            }
        }
        string sBillingID;
        void vPurchase()
        {
            int count = 0;
            for (int a = 0; a < dgOrderList.RowCount; a++)
            {
                if (dgOrderList.Rows[a].Cells[1].Value.ToString() == rtItem.Text)
                    count++;
                break;
            }
            if (count > 0)
            {
                MessageBox.Show("The customer has already purchased " + rtItem.Text, "Unable to purchase");
            }
            else
            {
                vBillingID();
                if (dgOrderList.RowCount == 0)
                {
                    try
                    {
                        wfLogIn.q = "insert into billing (billingid, custid, userid, flag, date) values ('" + sBillingID
                            + "','" + sCustID
                            + "','" + wfLogIn.dbuserid
                            + "','" + "N"
                            + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        wfLogIn.vSelect();
                    }
                    catch { }
                }
                vSubID();
                wfLogIn.q = "insert into sub (subid, billingid, barcode, qty, price, amount, void, date) values ('" + sSubID
                    + "','" + sBillingID
                    + "','" + txtBarcode.Text
                    + "','" + txtQty.Text
                    + "','" + dPrice
                    + "','" + dAmount
                    + "','N','"+DateTime.Now.ToString("yyyy-MM-dd")+"')";
                wfLogIn.vSelect();
                vMonID();
                wfLogIn.q = "insert into monitor"
                    + " (monid, userid, custid, barcode, date, remainqty, recqty, delqty, newqty, manudate, expidate)"
                    + " values ('" + sMonID
                    + "','" + wfLogIn.dbuserid
                    + "','" + sCustID
                    + "','" + txtBarcode.Text
                    + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                    + "','" + iQty
                    + "','" + 0
                    + "','" + txtQty.Text
                    + "','" + (iQty - Convert.ToInt32(txtQty.Text))
                    + "','" + dManuDate.ToString("yyyy-MM-dd")
                    + "','" + dExpiDate.ToString("yyyy-MM-dd")
                    + "')";
                wfLogIn.vSelect();
                wfLogIn.q = "update product set qty = (qty - " + txtQty.Text + ") where barcode = '"
                    + txtBarcode.Text + "'";
                wfLogIn.vSelect();
                vOrderedProduct();
            }
        }
        public static String sMonID;
        public static void vMonID()
        {
            wfLogIn.q = "select count(monid) from monitor where date like '"+DateTime.Now.ToString("yyyy")+"%'";
            wfLogIn.vSelect();
            sMonID = DateTime.Now.ToString("yyyy-") + (Convert.ToInt32(wfLogIn.t.Rows[0][0]) + 1).ToString("d5");
        }
        void vSubID()
        {
            wfLogIn.q = "SELECT count(subid) FROM sub where date like '" + DateTime.Now.ToString("yyyy") + "%'";
            wfLogIn.vSelect();
            sSubID = DateTime.Now.ToString("yyyy-") + (Convert.ToInt32(wfLogIn.t.Rows[0][0]) + 1).ToString("d5");
        }
        string sSubID;
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                vPurchase(); 
            }
        }
        string sCustID;
        private void dgCust_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sCustID = dgCust.Rows[dgCust.CurrentCell.RowIndex].Cells[0].Value.ToString();
                vOrderedProduct();
            }
            catch { }
        }
        void vPayment()
        {

        }
        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }
    }
}