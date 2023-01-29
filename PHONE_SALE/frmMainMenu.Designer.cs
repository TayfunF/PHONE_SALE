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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.panelMid = new System.Windows.Forms.Panel();
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTelephone = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPhoneList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMarkaveModel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemmarkaEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemmarkaListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemmodelEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemmodelListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMakeSale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaleList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMid
            // 
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 25);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1212, 501);
            this.panelMid.TabIndex = 2;
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.toolStripMenuItemTelephone,
            this.ToolStripMenuItemMarkaveModel,
            this.ToolStripMenuItemUser,
            this.ToolStripMenuItemCustomer,
            this.ToolStripMenuItemSale});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Size = new System.Drawing.Size(1212, 25);
            this.menuStripMainMenu.TabIndex = 6;
            this.menuStripMainMenu.Text = "Ana Menü";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings,
            this.ToolStripMenuItemExit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Image = global::PHONE_SALE.Properties.Resources.settings;
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(170, 22);
            this.ToolStripMenuItemSettings.Text = "Ayarlar";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Image = global::PHONE_SALE.Properties.Resources.busy;
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(170, 22);
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
            this.toolStripMenuItemTelephone.Size = new System.Drawing.Size(78, 21);
            this.toolStripMenuItemTelephone.Text = "Telefon";
            // 
            // ToolStripMenuItemAddPhone
            // 
            this.ToolStripMenuItemAddPhone.Image = global::PHONE_SALE.Properties.Resources.plus;
            this.ToolStripMenuItemAddPhone.Name = "ToolStripMenuItemAddPhone";
            this.ToolStripMenuItemAddPhone.Size = new System.Drawing.Size(157, 22);
            this.ToolStripMenuItemAddPhone.Text = "Telefon Ekle";
            this.ToolStripMenuItemAddPhone.Click += new System.EventHandler(this.ToolStripMenuItemAddPhone_Click);
            // 
            // ToolStripMenuItemPhoneList
            // 
            this.ToolStripMenuItemPhoneList.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemPhoneList.Name = "ToolStripMenuItemPhoneList";
            this.ToolStripMenuItemPhoneList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolStripMenuItemPhoneList.Size = new System.Drawing.Size(157, 22);
            this.ToolStripMenuItemPhoneList.Text = "Telefon Listesi";
            this.ToolStripMenuItemPhoneList.Click += new System.EventHandler(this.ToolStripMenuItemPhoneList_Click);
            // 
            // ToolStripMenuItemMarkaveModel
            // 
            this.ToolStripMenuItemMarkaveModel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemmarkaEkle,
            this.ToolStripMenuItemmarkaListesi,
            this.ToolStripMenuItemmodelEkle,
            this.ToolStripMenuItemmodelListesi});
            this.ToolStripMenuItemMarkaveModel.Image = global::PHONE_SALE.Properties.Resources.sitemap;
            this.ToolStripMenuItemMarkaveModel.Name = "ToolStripMenuItemMarkaveModel";
            this.ToolStripMenuItemMarkaveModel.Size = new System.Drawing.Size(132, 21);
            this.ToolStripMenuItemMarkaveModel.Text = "Marka ve Model";
            // 
            // ToolStripMenuItemmarkaEkle
            // 
            this.ToolStripMenuItemmarkaEkle.Image = global::PHONE_SALE.Properties.Resources.plus;
            this.ToolStripMenuItemmarkaEkle.Name = "ToolStripMenuItemmarkaEkle";
            this.ToolStripMenuItemmarkaEkle.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemmarkaEkle.Text = "Marka Ekle";
            this.ToolStripMenuItemmarkaEkle.Click += new System.EventHandler(this.ToolStripMenuItemmarkaEkle_Click);
            // 
            // ToolStripMenuItemmarkaListesi
            // 
            this.ToolStripMenuItemmarkaListesi.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemmarkaListesi.Name = "ToolStripMenuItemmarkaListesi";
            this.ToolStripMenuItemmarkaListesi.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemmarkaListesi.Text = "Marka Listesi";
            // 
            // ToolStripMenuItemmodelEkle
            // 
            this.ToolStripMenuItemmodelEkle.Image = global::PHONE_SALE.Properties.Resources.plus;
            this.ToolStripMenuItemmodelEkle.Name = "ToolStripMenuItemmodelEkle";
            this.ToolStripMenuItemmodelEkle.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemmodelEkle.Text = "Model Ekle";
            // 
            // ToolStripMenuItemmodelListesi
            // 
            this.ToolStripMenuItemmodelListesi.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemmodelListesi.Name = "ToolStripMenuItemmodelListesi";
            this.ToolStripMenuItemmodelListesi.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemmodelListesi.Text = "Model Listesi";
            // 
            // ToolStripMenuItemUser
            // 
            this.ToolStripMenuItemUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddUser,
            this.ToolStripMenuItemUserList});
            this.ToolStripMenuItemUser.Image = global::PHONE_SALE.Properties.Resources.User_32x32;
            this.ToolStripMenuItemUser.Name = "ToolStripMenuItemUser";
            this.ToolStripMenuItemUser.Size = new System.Drawing.Size(83, 21);
            this.ToolStripMenuItemUser.Text = "Kullanıcı";
            // 
            // ToolStripMenuItemAddUser
            // 
            this.ToolStripMenuItemAddUser.Image = global::PHONE_SALE.Properties.Resources.plus;
            this.ToolStripMenuItemAddUser.Name = "ToolStripMenuItemAddUser";
            this.ToolStripMenuItemAddUser.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItemAddUser.Text = "Kullanıcı Ekle";
            this.ToolStripMenuItemAddUser.Click += new System.EventHandler(this.ToolStripMenuItemAddUser_Click);
            // 
            // ToolStripMenuItemUserList
            // 
            this.ToolStripMenuItemUserList.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemUserList.Name = "ToolStripMenuItemUserList";
            this.ToolStripMenuItemUserList.Size = new System.Drawing.Size(162, 22);
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
            this.ToolStripMenuItemCustomer.Size = new System.Drawing.Size(80, 21);
            this.ToolStripMenuItemCustomer.Text = "Müşteri";
            // 
            // ToolStripMenuItemAddCustomer
            // 
            this.ToolStripMenuItemAddCustomer.Image = global::PHONE_SALE.Properties.Resources.plus;
            this.ToolStripMenuItemAddCustomer.Name = "ToolStripMenuItemAddCustomer";
            this.ToolStripMenuItemAddCustomer.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItemAddCustomer.Text = "Müşteri Ekle";
            this.ToolStripMenuItemAddCustomer.Click += new System.EventHandler(this.ToolStripMenuItemAddCustomer_Click);
            // 
            // ToolStripMenuItemCustomerList
            // 
            this.ToolStripMenuItemCustomerList.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemCustomerList.Name = "ToolStripMenuItemCustomerList";
            this.ToolStripMenuItemCustomerList.Size = new System.Drawing.Size(159, 22);
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
            this.ToolStripMenuItemSale.Size = new System.Drawing.Size(63, 21);
            this.ToolStripMenuItemSale.Text = "Satış";
            // 
            // ToolStripMenuItemMakeSale
            // 
            this.ToolStripMenuItemMakeSale.Image = global::PHONE_SALE.Properties.Resources.payment_card;
            this.ToolStripMenuItemMakeSale.Name = "ToolStripMenuItemMakeSale";
            this.ToolStripMenuItemMakeSale.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemMakeSale.Text = "Satış Yap";
            this.ToolStripMenuItemMakeSale.Click += new System.EventHandler(this.ToolStripMenuItemMakeSale_Click);
            // 
            // ToolStripMenuItemSaleList
            // 
            this.ToolStripMenuItemSaleList.Image = global::PHONE_SALE.Properties.Resources.order;
            this.ToolStripMenuItemSaleList.Name = "ToolStripMenuItemSaleList";
            this.ToolStripMenuItemSaleList.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemSaleList.Text = "Satış Listesi";
            this.ToolStripMenuItemSaleList.Click += new System.EventHandler(this.ToolStripMenuItemSaleList_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1212, 526);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.menuStripMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.MenuStrip menuStripMainMenu;
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMarkaveModel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemmarkaEkle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemmarkaListesi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemmodelEkle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemmodelListesi;
    }
}

