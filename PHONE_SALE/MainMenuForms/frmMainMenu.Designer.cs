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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.imageListMainMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnSaleList = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnPhoneList = new System.Windows.Forms.Button();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SkyBlue;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnSaleList);
            this.panelTop.Controls.Add(this.btnSale);
            this.panelTop.Controls.Add(this.btnCustomerList);
            this.panelTop.Controls.Add(this.btnAddCustomer);
            this.panelTop.Controls.Add(this.btnUserList);
            this.panelTop.Controls.Add(this.btnAddUser);
            this.panelTop.Controls.Add(this.btnPhoneList);
            this.panelTop.Controls.Add(this.btnAddPhone);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(824, 112);
            this.panelTop.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageKey = "Delete_32x32.png";
            this.btnExit.ImageList = this.imageListMainMenu;
            this.btnExit.Location = new System.Drawing.Point(732, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 82);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Çıkış";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // btnSaleList
            // 
            this.btnSaleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaleList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaleList.ImageKey = "order.png";
            this.btnSaleList.ImageList = this.imageListMainMenu;
            this.btnSaleList.Location = new System.Drawing.Point(642, 11);
            this.btnSaleList.Name = "btnSaleList";
            this.btnSaleList.Size = new System.Drawing.Size(85, 82);
            this.btnSaleList.TabIndex = 7;
            this.btnSaleList.Text = "Satış Listesi";
            this.btnSaleList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaleList.UseVisualStyleBackColor = true;
            this.btnSaleList.Click += new System.EventHandler(this.btnSaleList_Click);
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSale.ImageKey = "payment-card.png";
            this.btnSale.ImageList = this.imageListMainMenu;
            this.btnSale.Location = new System.Drawing.Point(552, 11);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(85, 82);
            this.btnSale.TabIndex = 6;
            this.btnSale.Text = "Satış Yap";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomerList.ImageKey = "customers.png";
            this.btnCustomerList.ImageList = this.imageListMainMenu;
            this.btnCustomerList.Location = new System.Drawing.Point(462, 11);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(85, 82);
            this.btnCustomerList.TabIndex = 5;
            this.btnCustomerList.Text = "Müşteri Listesi";
            this.btnCustomerList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerList.UseVisualStyleBackColor = true;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCustomer.ImageKey = "plus.png";
            this.btnAddCustomer.ImageList = this.imageListMainMenu;
            this.btnAddCustomer.Location = new System.Drawing.Point(372, 11);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(85, 82);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserList.ImageKey = "user.png";
            this.btnUserList.ImageList = this.imageListMainMenu;
            this.btnUserList.Location = new System.Drawing.Point(282, 11);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(85, 82);
            this.btnUserList.TabIndex = 3;
            this.btnUserList.Text = "Kullanıcı Listesi";
            this.btnUserList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserList.UseVisualStyleBackColor = true;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddUser.ImageKey = "plus.png";
            this.btnAddUser.ImageList = this.imageListMainMenu;
            this.btnAddUser.Location = new System.Drawing.Point(192, 12);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(85, 82);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Kullanıcı Ekle";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnPhoneList
            // 
            this.btnPhoneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhoneList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhoneList.ImageKey = "mobile-phone.png";
            this.btnPhoneList.ImageList = this.imageListMainMenu;
            this.btnPhoneList.Location = new System.Drawing.Point(102, 12);
            this.btnPhoneList.Name = "btnPhoneList";
            this.btnPhoneList.Size = new System.Drawing.Size(85, 82);
            this.btnPhoneList.TabIndex = 1;
            this.btnPhoneList.Text = "Telefon Listesi";
            this.btnPhoneList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhoneList.UseVisualStyleBackColor = true;
            this.btnPhoneList.Click += new System.EventHandler(this.btnPhoneList_Click);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPhone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPhone.ImageKey = "plus.png";
            this.btnAddPhone.ImageList = this.imageListMainMenu;
            this.btnAddPhone.Location = new System.Drawing.Point(12, 12);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(85, 82);
            this.btnAddPhone.TabIndex = 0;
            this.btnAddPhone.Text = "Telefon Ekle";
            this.btnAddPhone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // panelMid
            // 
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 112);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(824, 414);
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
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(824, 526);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Satış Ana Menü";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Button btnPhoneList;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnSaleList;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imageListMainMenu;
    }
}

