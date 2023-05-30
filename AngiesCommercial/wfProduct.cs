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
    public partial class wfProduct : Form
    {
        public wfProduct()
        {
            InitializeComponent();
        }

        private void wfMotor_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-ph");
            wfLogIn.q = "SELECT barcode 'BARCODE'"//0
                + ", name `NAME`"//1
                + ", type `TYPE`"//2
                + ", qty `QTY`"//3
                + ", crititem `CRITICAL ITEM`"//4
                + ", price `PRICE`"//5
                + ", manudate `MANUFACTURED DATE`"//6
                + ", expidate `EXPIRATION DATE`"//7
                +" FROM product";
            wfLogIn.vSelect();
            dgUser.DataSource = wfLogIn.t;
            //dgUser.Columns[0].Visible = false;
            dgUser.Columns[5].DefaultCellStyle.Format = "c";
            dgUser.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgUser.Columns[6].DefaultCellStyle.Format = "MMM. dd yyyy";
            dgUser.Columns[7].DefaultCellStyle.Format = "MMM. dd yyyy";
            lbResult.Text = dgUser.Rows.Count + " product result has found!";
            dgUser.Columns[1].Width = 300;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            sSave = "Add";
            vCallMotor();
            wfMotor_Load(sender, e);
        }
        void vCallMotor()
        {
            wfProductSet s = new wfProductSet();
            s.ShowDialog();
        }
        private void bnEdit_Click(object sender, EventArgs e)
        {
            sSave = "Edit";
            vCallMotor();
            wfMotor_Load(sender, e);
        }
        public static Double dPrice;
        public static String sSave, sBarcode, sName, sType;
        public static DateTime dtManudate, dtExpidate;
        public static Int32 iQty, iCrititem;
        private void dgUser_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                sBarcode = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[0].Value.ToString();
                sName = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[1].Value.ToString();
                sType = dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[2].Value.ToString();
                iQty = Convert.ToInt32(dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[3].Value);
                iCrititem = Convert.ToInt32(dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[4].Value);
                dPrice = Convert.ToDouble(dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[5].Value);
                dtManudate = Convert.ToDateTime(dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[6].Value);
                dtExpidate = Convert.ToDateTime(dgUser.Rows[dgUser.CurrentCell.RowIndex].Cells[7].Value);
            }
            catch { }
        }

        private void bnSearch_Click(object sender, EventArgs e)
        {
            wfMotor_Load(sender,e);
        }

        private void bnAddExistind_Click(object sender, EventArgs e)
        {
            wfAddExisting a = new wfAddExisting();
            a.ShowDialog();
            wfMotor_Load(sender, e);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = print.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }
        Printing print;
        private bool SetupThePrinting()
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
            printDocument1.DocumentName = "List of Product";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            printDocument1.DefaultPageSettings.Landscape = MyPrintDialog.PrinterSettings.DefaultPageSettings.Landscape;
            print = new Printing(dgUser, printDocument1, true, true, printDocument1.DocumentName
                , new Font("Tahoma", 18, FontStyle.Bold,
                GraphicsUnit.Point), Color.Black, true);
            return true;
        }
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
    }
}