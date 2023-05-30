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
    public partial class wfCustomerSet : Form
    {
        public wfCustomerSet()
        {
            InitializeComponent();
        }
        private void wfCustomerSet_Load(object sender, EventArgs e)
        {
            if (wfCustomer.sSave == "Edit")
            {
                txtAddress.Text = wfCustomer.saddress;
                txtName.Text = wfCustomer.sname;
                txtConNum.Text = wfCustomer.sconNum;
            }          
        }
        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        void vCustID()
        {
            wfLogIn.q = "select count(custid) from cust where datereg like '" + DateTime.Now.ToString("yyyy") + "%'";
            wfLogIn.vSelect();
            sCustID = DateTime.Now.ToString("yyyy-") + (Convert.ToInt32(wfLogIn.t.Rows[0][0]) + 1).ToString("d5");
        }
        string sCustID;
        private void bnSave_Click(object sender, EventArgs e)
        {
            if (wfCustomer.sSave == "Add")
            {
                vCustID();
                wfLogIn.q = "insert into cust (custid, name, connum, address, datereg) values ('" + sCustID
                    + "','" + txtName.Text
                    + "','" + txtConNum.Text
                    + "','" + txtAddress.Text
                    + "','"+DateTime.Now.ToString("yyyy-MM-dd")+"')";
            }
            else
            {
                wfLogIn.q = "update cust set name = '" + txtName.Text
                    + "', connum = '" + txtConNum.Text
                    + "', address = '" + txtAddress.Text
                    + "' where custid = '" + wfCustomer.scustid + "'";
            }
            wfLogIn.vSelect();
            Close();
        }
    }
}
