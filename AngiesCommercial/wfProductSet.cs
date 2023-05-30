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
    public partial class wfProductSet : Form
    {
        public wfProductSet()
        {
            InitializeComponent();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bnSave_Click(object sender, EventArgs e)
        {
            if (wfProduct.sSave == "Add")
            {
                wfLogIn.q = "select barcode from product where barcode = '" + txtBarcode.Text + "'";
                wfLogIn.vSelect();
                if (wfLogIn.t.Rows.Count == 0)
                {
                    wfLogIn.q = "insert into product (barcode, name, type, qty, price, crititem, manudate, expidate) values ('" + txtBarcode.Text
                        + "','" + txtName.Text
                        + "','" + cbType.Text
                        + "','" + txtQty.Text
                        + "','" + txtPrice.Text
                        + "','" + txtCritItem.Text
                        + "','" + dtManufaturedDate.Value.ToString("yyyy-MM-dd")
                        + "','" + dtExpirationDate.Value.ToString("yyyy-MM-dd") + "')";
                    wfLogIn.vSelect();
                    wfPurchase.vMonID();
                    wfLogIn.q = "insert into monitor (monid, userid, custid, barcode, date, remainqty, recqty, delqty, newqty, manudate, expidate) values ('"+wfPurchase.sMonID
                        +"','" + wfLogIn.dbuserid
                        + "','1','" + txtBarcode.Text
                        + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                        + "','0','" + txtQty.Text
                        + "','0','" + txtQty.Text
                        + "','" + dtManufaturedDate.Value.ToString("yyyy-MM-dd")
                        + "','" + dtExpirationDate.Value.ToString("yyyy-MM-dd") + "')";
                    wfLogIn.vSelect();
                }
                else
                {
                    MessageBox.Show("Product is already exist", "Unable to add product");
                    txtBarcode.Focus();
                }
            }
            else
            {
                wfLogIn.q = "update product set barcode = '" + txtBarcode.Text
                    + "', name = '" + txtName.Text
                    + "', type = '" + cbType.Text
                    + "', price = '" + txtPrice.Text
                    + "', crititem = '" + txtCritItem.Text
                    + "', manudate = '" + dtManufaturedDate.Value.ToString("yyyy-MM-dd")
                    + "', expidate = '" + dtExpirationDate.Value.ToString("yyyy-MM-dd")
                    + "' where barcode = '" + wfProduct.sBarcode + "'";
                wfLogIn.vSelect();
            }
            Close();
        }

        private void wfMotorSet_Load(object sender, EventArgs e)
        {
            if (wfProduct.sSave == "Edit")
            {
                txtBarcode.Text = wfProduct.sBarcode;
                txtCritItem.Text = wfProduct.iCrititem.ToString();
                txtName.Text = wfProduct.sName;
                txtPrice.Text = wfProduct.dPrice.ToString("n");
                txtQty.Text = wfProduct.iQty.ToString();
                cbType.Text = wfProduct.sType;
                dtExpirationDate.Text = wfProduct.dtExpidate.ToString();
                dtManufaturedDate.Text = wfProduct.dtManudate.ToString();
                txtQty.Enabled = false;
            }
        }
    }
}