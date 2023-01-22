namespace PHONE_SALE
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.imageListMainMenu = new System.Windows.Forms.ImageList(this.components);
            this.panelMid = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTelephone = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPhoneList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMakeSale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaleList = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListMainMenu
            // 
            this.imageListMainMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMainMenu.ImageStream")));
            this.imageListMainMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMainMenu.Images.SetKeyName(0, "plus.png");
            this.imageListMainMenu.Images.SetKeyName(1, "mobile-phone.png");
            this.imageListMainMenu.Images.SetKeyName(2, "user.png");
            this.imageListMainMenu.Images.SetKeyName(3, "customers.png");
            this.imageListMainMenu.Images.SetKeyName(4, "payment-card.png");
            this.imageListMainMenu.Images.SetKeyName(5, "order.png");
            this.imageListMainMenu.Images.SetKeyName(6, "Delete_32x32.png");
            // 
            // panelMid
            // 
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 24);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(824, 502);
            this.panelMid.TabIndex = 2;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 489);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(824, 37);
            this.panelBottom.TabIndex = 4;
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.toolStripMenuItemTelephone,
            this.ToolStripMenuItemUser,
            this.ToolStripMenuItemCustomer,
            this.ToolStripMenuItemSale});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(824, 24);
            this.msMainMenu.TabIndex = 6;
            this.msMainMenu.Text = "Ana Menü";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings,
            this.ToolStripMenuItemExit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Image = global::PHONE_SALE.Properties.Resources.settings;
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItemSettings.Text = "Ayarlar";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Image = global::PHONE_SALE.Properties.Resources.busy;
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItemExit.Text = "Programdan Çık";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemTelephone
            // 
            this.toolStripMenuItemTelephone.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddPhone,
            this.ToolStripMenuItemPhoneList});
            this.toolStripMenuItemTelephone.Image = global::PHONE_SALE.Properties.Resources.mobile_phone;
            this.toolStripMenuItemTelephone.Name = "toolStripMenuItemTelephone";
            this.toolStripMenuItemTelephone.Size = new System.Drawing.Size(120, 20);
            this.toolStripMenuItemTelephone.Text = "Telefon İşlemleri";
            // 
            // ToolStripMenuItemAddPhone
            // 
            this.ToolStripMenuItemAddPhone.Image = global::PHONE_SALE.Properties.Resources.plus;
            this.ToolStripMenuItemAddPhone.Name = "ToolStripMenuItemAddPhone";
            this.ToolStripMenuItemAddPhone.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemAddPhone.Text = "Telefon Ekle";
            this.ToolStripMenuItemAddPhone.Click += new System.EventHandler(this.ToolStripMenuItemAddPhone_Click);
            // 
            // ToolStripMenuItemPhoneList
            // 
            this.ToolStripMenuItemPhoneList.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemPhoneList.Name = "ToolStripMenuItemPhoneList";
            this.ToolStripMenuItemPhoneList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolStripMenuItemPhoneList.Size = new System.Drawing.Size(147, 22);
            this.ToolStripMenuItemPhoneList.Text = "Telefon Listesi";
            this.ToolStripMenuItemPhoneList.Click += new System.EventHandler(this.ToolStripMenuItemPhoneList_Click);
            // 
            // ToolStripMenuItemUser
            // 
            this.ToolStripMenuItemUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddUser,
            this.ToolStripMenuItemUserList});
            this.ToolStripMenuItemUser.Image = global::PHONE_SALE.Properties.Resources.User_32x32;
            this.ToolStripMenuItemUser.Name = "ToolStripMenuItemUser";
            this.ToolStripMenuItemUser.Size = new System.Drawing.Size(127, 20);
            this.ToolStripMenuItemUser.Text = "Kullanıcı İşlemleri";
            // 
            // ToolStripMenuItemAddUser
            // 
            this.ToolStripMenuItemAddUser.Image = global::PHONE_SALE.Properties.Resources.plus;
            this.ToolStripMenuItemAddUser.Name = "ToolStripMenuItemAddUser";
            this.ToolStripMenuItemAddUser.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItemAddUser.Text = "Kullanıcı Ekle";
            this.ToolStripMenuItemAddUser.Click += new System.EventHandler(this.ToolStripMenuItemAddUser_Click);
            // 
            // ToolStripMenuItemUserList
            // 
            this.ToolStripMenuItemUserList.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemUserList.Name = "ToolStripMenuItemUserList";
            this.ToolStripMenuItemUserList.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItemUserList.Text = "Kullanıcı Listesi";
            this.ToolStripMenuItemUserList.Click += new System.EventHandler(this.ToolStripMenuItemUserList_Click);
            // 
            // ToolStripMenuItemCustomer
            // 
            this.ToolStripMenuItemCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddCustomer,
            this.ToolStripMenuItemCustomerList});
            this.ToolStripMenuItemCustomer.Image = global::PHONE_SALE.Properties.Resources.customers;
            this.ToolStripMenuItemCustomer.Name = "ToolStripMenuItemCustomer";
            this.ToolStripMenuItemCustomer.Size = new System.Drawing.Size(122, 20);
            this.ToolStripMenuItemCustomer.Text = "Müşteri İşlemleri";
            // 
            // ToolStripMenuItemAddCustomer
            // 
            this.ToolStripMenuItemAddCustomer.Image = global::PHONE_SALE.Properties.Resources.plus;
            this.ToolStripMenuItemAddCustomer.Name = "ToolStripMenuItemAddCustomer";
            this.ToolStripMenuItemAddCustomer.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemAddCustomer.Text = "Müşteri Ekle";
            this.ToolStripMenuItemAddCustomer.Click += new System.EventHandler(this.ToolStripMenuItemAddCustomer_Click);
            // 
            // ToolStripMenuItemCustomerList
            // 
            this.ToolStripMenuItemCustomerList.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemCustomerList.Name = "ToolStripMenuItemCustomerList";
            this.ToolStripMenuItemCustomerList.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemCustomerList.Text = "Müşteri Listesi";
            this.ToolStripMenuItemCustomerList.Click += new System.EventHandler(this.ToolStripMenuItemCustomerList_Click);
            // 
            // ToolStripMenuItemSale
            // 
            this.ToolStripMenuItemSale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMakeSale,
            this.ToolStripMenuItemSaleList});
            this.ToolStripMenuItemSale.Image = global::PHONE_SALE.Properties.Resources.basket;
            this.ToolStripMenuItemSale.Name = "ToolStripMenuItemSale";
            this.ToolStripMenuItemSale.Size = new System.Drawing.Size(106, 20);
            this.ToolStripMenuItemSale.Text = "Satış İşlemleri";
            // 
            // ToolStripMenuItemMakeSale
            // 
            this.ToolStripMenuItemMakeSale.Image = global::PHONE_SALE.Properties.Resources.payment_card;
            this.ToolStripMenuItemMakeSale.Name = "ToolStripMenuItemMakeSale";
            this.ToolStripMenuItemMakeSale.Size = new System.Drawing.Size(133, 22);
            this.ToolStripMenuItemMakeSale.Text = "Satış Yap";
            this.ToolStripMenuItemMakeSale.Click += new System.EventHandler(this.ToolStripMenuItemMakeSale_Click);
            // 
            // ToolStripMenuItemSaleList
            // 
            this.ToolStripMenuItemSaleList.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemSaleList.Name = "ToolStripMenuItemSaleList";
            this.ToolStripMenuItemSaleList.Size = new System.Drawing.Size(133, 22);
            this.ToolStripMenuItemSaleList.Text = "Satış Listesi";
            this.ToolStripMenuItemSaleList.Click += new System.EventHandler(this.ToolStripMenuItemSaleList_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(824, 526);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ImageList imageListMainMenu;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTelephone;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddPhone;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPhoneList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUserList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCustomer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCustomerList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSale;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMakeSale;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaleList;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
    }
}

