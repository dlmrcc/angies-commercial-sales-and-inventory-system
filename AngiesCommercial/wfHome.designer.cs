namespace AngiesCommercial
{
    partial class wfHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mnItem = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmDate = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bnMotor = new System.Windows.Forms.ToolStripButton();
            this.cbCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbDate = new System.Windows.Forms.ToolStripLabel();
            this.lbUser = new System.Windows.Forms.ToolStripLabel();
            this.ttHome = new System.Windows.Forms.ToolTip(this.components);
            this.bnPurchase = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.mnItem.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::AngiesCommercial.Properties.Resources.Interface__25__;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Poblacion District II, Brooke\'s Point Palawan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(801, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Angie\'s Commercial Sales and Inventory System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnItem
            // 
            this.mnItem.BackColor = System.Drawing.Color.White;
            this.mnItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnItem.BackgroundImage")));
            this.mnItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mnItem.Location = new System.Drawing.Point(0, 0);
            this.mnItem.Name = "mnItem";
            this.mnItem.Size = new System.Drawing.Size(963, 24);
            this.mnItem.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUsernameToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeUsernameToolStripMenuItem
            // 
            this.changeUsernameToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.changeUsernameToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeUsernameToolStripMenuItem.BackgroundImage")));
            this.changeUsernameToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeUsernameToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.changeUsernameToolStripMenuItem.Name = "changeUsernameToolStripMenuItem";
            this.changeUsernameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.changeUsernameToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.changeUsernameToolStripMenuItem.Text = "&Change User Information";
            this.changeUsernameToolStripMenuItem.Click += new System.EventHandler(this.changeUsernameToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.BackgroundImage")));
            this.logOutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.logOutToolStripMenuItem.Text = "&Log - Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInformationToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.informationToolStripMenuItem.Text = "Configuration";
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.BackgroundImage = global::AngiesCommercial.Properties.Resources.Interface__25__;
            this.userInformationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.userInformationToolStripMenuItem.Text = "User Configure";
            this.userInformationToolStripMenuItem.Click += new System.EventHandler(this.userInformationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInHistoryToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // logInHistoryToolStripMenuItem
            // 
            this.logInHistoryToolStripMenuItem.BackgroundImage = global::AngiesCommercial.Properties.Resources.Interface__25__;
            this.logInHistoryToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInHistoryToolStripMenuItem.Name = "logInHistoryToolStripMenuItem";
            this.logInHistoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.logInHistoryToolStripMenuItem.Text = "Log - In History";
            this.logInHistoryToolStripMenuItem.Click += new System.EventHandler(this.logInHistoryToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.BackgroundImage = global::AngiesCommercial.Properties.Resources.Interface__25__;
            this.inventoryToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // tmDate
            // 
            this.tmDate.Interval = 1000;
            this.tmDate.Tick += new System.EventHandler(this.tmDate_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnMotor,
            this.cbCustomer,
            this.bnPurchase});
            this.toolStrip1.Location = new System.Drawing.Point(0, 120);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(963, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bnMotor
            // 
            this.bnMotor.ForeColor = System.Drawing.Color.White;
            this.bnMotor.Image = ((System.Drawing.Image)(resources.GetObject("bnMotor.Image")));
            this.bnMotor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnMotor.Name = "bnMotor";
            this.bnMotor.Size = new System.Drawing.Size(69, 22);
            this.bnMotor.Text = "Product";
            this.bnMotor.Click += new System.EventHandler(this.bnProduct_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.ForeColor = System.Drawing.Color.White;
            this.cbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cbCustomer.Image")));
            this.cbCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(79, 22);
            this.cbCustomer.Text = "Customer";
            this.cbCustomer.Click += new System.EventHandler(this.cbCustomer_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDate,
            this.lbUser});
            this.toolStrip2.Location = new System.Drawing.Point(0, 351);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(963, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lbDate
            // 
            this.lbDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 22);
            // 
            // lbUser
            // 
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(0, 22);
            // 
            // bnPurchase
            // 
            this.bnPurchase.ForeColor = System.Drawing.Color.White;
            this.bnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("bnPurchase.Image")));
            this.bnPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnPurchase.Name = "bnPurchase";
            this.bnPurchase.Size = new System.Drawing.Size(75, 22);
            this.bnPurchase.Text = "Purchase";
            this.bnPurchase.Click += new System.EventHandler(this.bnPurchase_Click);
            // 
            // wfHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 376);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnItem);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnItem;
            this.Name = "wfHome";
            this.Text = "Computerized Sales and Inventory System of Rusi (Brooke\'s Point Branch) - Home Fo" +
                "rm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfHome_FormClosing);
            this.Load += new System.EventHandler(this.wfHome_Load);
            this.Resize += new System.EventHandler(this.wfHome_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnItem.ResumeLayout(false);
            this.mnItem.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnItem;
        private System.Windows.Forms.Timer tmDate;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lbDate;
        private System.Windows.Forms.ToolStripLabel lbUser;
        private System.Windows.Forms.ToolStripMenuItem changeUsernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttHome;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton cbCustomer;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnMotor;
        private System.Windows.Forms.ToolStripMenuItem logInHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnPurchase;

    }
}