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
    public partial class wfCustomer : Form
    {
        public wfCustomer()
        {
            InitializeComponent();
        }

        private void wfCustomer_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT custid,"
                + " name `NAME OR COMPANY`,"
                + " connum `CONTACT NUMBER`,"
                + " ADDRESS FROM cust where custid != '2012-00001'";
            wfLogIn.vSelect();
            dgUser.DataSource = wfLogIn.t;
            dgUser.Columns[0].Visible = false;
        }

        private void bnSearch_Click(object sender, EventArgs e)
        {
            wfCustomer_Load(sender, e);
        }
        public static String scustid, sname, sconNum,saddress, sSave;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            vCallCustomer();
            wfCustomer_Load(sender, e);
        }
        void vCallCustomer()
        {
            wfCustomerSet s = new wfCustomerSet();
            s.ShowDialog();
        }
        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            vCallCustomer();
            wfCustomer_Load(sender, e);
        }
        Printing print;
        private bool SetupThePrinting()//==================
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;
            printDocument1.DocumentName = "Customer Information";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgUser, printDocument1, true, true, printDocument1.DocumentName
                , new Font("Tahoma", 18, FontStyle.Bold,
                GraphicsUnit.Point), Color.Black, true);
            return true;
        }//=================
        private void bnPrint_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = printDocument1;
                MyPrintPreviewDialog.ShowDialog();
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        private void dgUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                scustid = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sname = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[1].Value.ToString();                
                sconNum = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[2].Value.ToString();
                saddress = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[3].Value.ToString();
            }
            catch { }
        }
    }
}