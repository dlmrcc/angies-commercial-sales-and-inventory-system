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
    public partial class wfInventory : Form
    {
        public wfInventory()
        {
            InitializeComponent();
        }

        private void wfMonitoring_Load(object sender, EventArgs e)
        {
            wfLogIn.q = "SELECT concat('[',u.utype,'] ',u.fname,' ',u.lname) `USER`,"
                + " concat(c.fname,' ',c.mname,' ',c.lname) `CUSTOMER`,"
                + " name `PRODUCT`,"
                + " m.`remainqty` `REMAINING QTY`,"
                + " m.`recqty` `RECEIVED QTY`,"
                + " m.`delqty` `DELIVER QTY`,"
                + " m.`newqty` `NEW QTY`,"
                + " m.`date` `DATE`"
                + " FROM monitor m left join"
                + " (`user` u, cust c, product p)"
                + " on (u.userid = m.userid and c.custid ="
                + " m.custid and p.barcode = m.barcode)";
            wfLogIn.vSelect();
            dgMonitoring.DataSource = wfLogIn.t;
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
            printDocument1.DocumentName = "Motorcycle Inventory";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgMonitoring, printDocument1, true, true, "Motorcycle Inventory"
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
    }
}
