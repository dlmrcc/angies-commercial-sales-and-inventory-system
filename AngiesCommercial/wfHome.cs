using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace AngiesCommercial
{
    public partial class wfHome : Form
    {
        public wfHome()
        {
            InitializeComponent();
        }
        private void wfHome_Load(object sender, EventArgs e)
        {
            wfLogIn l = new wfLogIn();
            l.ShowDialog();
            tmDate.Enabled = false;
            if (wfLogIn.bExit == true)
                Close();
            else
            {
                vCallNameDate(sender, e);
            }
            tmDate.Enabled = !false;
        }
        void vCallNameDate(object sender, EventArgs e)
        {
            lbUser.Text = wfLogIn.dbutype + ": " + wfLogIn.dbfname + " " + wfLogIn.dblname
                + " [" + wfLogIn.dbuserid + "]";
            tmDate_Tick(sender, e);
        }
        private void tmDate_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dddd MMMM dd, yyyy hh:mm:ss tt");
        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfChangeUser c = new wfChangeUser();
            c.ShowDialog();
            vCallNameDate(sender, e);
        }

        private void wfHome_Resize(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wfLogIn.bExit != true)
            {
                if (MessageBox.Show("Do you want to Log - Out?"
                    , "Confirm Log - Out"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    wfLogIn.q = "update loghis set logout = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "' where userid = '" + wfLogIn.dbuserid
                        + "' and login = '" + wfLogIn.dLogIn + "'";
                    wfLogIn.vSelect();
                    foreach (Form c in MdiChildren)
                        c.Close();
                    lbDate.Text = "";
                    lbUser.Text = "";
                    tmDate.Enabled = false;
                    wfHome_Load(sender, e);
                    e.Cancel = true;
                }
            }
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfUser c = new wfUser();
                c.MdiParent = this;
                c.WindowState = FormWindowState.Maximized;
                c.Show();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                    , "Access Forbidden"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnProduct_Click(object sender, EventArgs e)
        {
            wfProduct m = new wfProduct();
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();
        }

        private void cbCustomer_Click(object sender, EventArgs e)
        {
            wfCustomer c = new wfCustomer();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }

        private void logInHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfLogInHistory h = new wfLogInHistory();
                h.MdiParent = this;
                h.WindowState = FormWindowState.Maximized;
                h.Show();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                    , "Access Forbidden"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Stop);
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wfLogIn.dbutype == "Admin")
            {
                wfInventory i = new wfInventory();
                i.MdiParent = this;
                i.WindowState = FormWindowState.Maximized;
                i.Show();
            }
            else
            {
                MessageBox.Show("You can't access this form."
                   , "Access Forbidden"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Stop);
            }
        }

        private void bnPurchase_Click(object sender, EventArgs e)
        {
            wfPurchase p = new wfPurchase();
            p.MdiParent = this;
            p.WindowState = FormWindowState.Maximized;
            p.Show();
        }
    }
}