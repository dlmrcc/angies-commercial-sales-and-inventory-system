using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AngiesCommercial
{
    public partial class wfAddExisting : Form
    {
        public wfAddExisting()
        {
            InitializeComponent();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfAddExisting_Load(object sender, EventArgs e)
        {
            lbBarcode.Text = wfProduct.sBarcode;
            lbName.Text = wfProduct.sName;
            lbType.Text = wfProduct.sType;
            lbPrice.Text = wfProduct.dPrice.ToString("c");
            lbQtyLeft.Text = wfProduct.iQty.ToString();
            dtManuDate.Text = wfProduct.dtManudate.ToString("MMM. dd, yyyy");
            dtExpiDate.Text = wfProduct.dtExpidate.ToString("MMM. dd, yyyy");
        }

        private void txtQuanArr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbNewQty.Text = Convert.ToDouble(Convert.ToDouble(wfProduct.iQty) + Convert.ToDouble(txtQuanArr.Text)).ToString();
            }
            catch { lbNewQty.Text = "0"; }
        }
        private void bnAdd_Click(object sender, EventArgs e)
        {
            wfLogIn.q = "insert into monitor (monid, userid, custid, barcode, date, remainqty, recqty, delqty, newqty,manudate,expidate) values (null,'" + wfLogIn.dbuserid
                + "','1','" + wfProduct.sBarcode
                + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                + "','" + wfProduct.iQty
                + "','" + txtQuanArr.Text
                + "','0','" + lbNewQty.Text
                + "','" + dtManuDate.Value.ToString("yyyy-MM-dd")
                + "','" + dtExpiDate.Value.ToString("yyyy-MM-dd") + "')";
            wfLogIn.vSelect();
            wfLogIn.q = "update product set qty = (qty + " + txtQuanArr.Text + "), gqty = (gqty + " + txtQuanArr.Text
                + ") where barcode = '" + wfProduct.sBarcode + "'";
            wfLogIn.vSelect();
            Close();
        }
    }
}
