namespace PHONE_SALE
{
    partial class frmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pbMsgIcon = new System.Windows.Forms.PictureBox();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.lblMessageCategory = new System.Windows.Forms.Label();
            this.panelMid = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMsgIcon)).BeginInit();
            this.panelMid.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Green;
            this.panelTop.Controls.Add(this.pbMsgIcon);
            this.panelTop.Controls.Add(this.lblMessageTitle);
            this.panelTop.Controls.Add(this.lblMessageCategory);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(414, 52);
            this.panelTop.TabIndex = 0;
            // 
            // pbMsgIcon
            // 
            this.pbMsgIcon.Location = new System.Drawing.Point(4, 2);
            this.pbMsgIcon.Name = "pbMsgIcon";
            this.pbMsgIcon.Size = new System.Drawing.Size(48, 48);
            this.pbMsgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMsgIcon.TabIndex = 2;
            this.pbMsgIcon.TabStop = false;
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessageTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMessageTitle.Location = new System.Drawing.Point(67, 27);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(50, 16);
            this.lblMessageTitle.TabIndex = 1;
            this.lblMessageTitle.Text = "Başlık";
            // 
            // lblMessageCategory
            // 
            this.lblMessageCategory.AutoSize = true;
            this.lblMessageCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessageCategory.ForeColor = System.Drawing.Color.Orange;
            this.lblMessageCategory.Location = new System.Drawing.Point(66, 5);
            this.lblMessageCategory.Name = "lblMessageCategory";
            this.lblMessageCategory.Size = new System.Drawing.Size(141, 20);
            this.lblMessageCategory.TabIndex = 0;
            this.lblMessageCategory.Text = "Mesaj Kategorisi";
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.lblMesaj);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 52);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(414, 175);
            this.panelMid.TabIndex = 1;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(4, 7);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(49, 16);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "Mesaj";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBottom.Controls.Add(this.btnNo);
            this.panelBottom.Controls.Add(this.btnYes);
            this.panelBottom.Controls.Add(this.btnOk);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 181);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(414, 46);
            this.panelBottom.TabIndex = 2;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Crimson;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(338, 3);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 40);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "Hayır";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Green;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(246, 3);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 40);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Evet";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(156, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 40);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Information_48x48.png");
            this.imgList.Images.SetKeyName(1, "Delete_48x48.png");
            this.imgList.Images.SetKeyName(2, "Help_48x48.png");
            this.imgList.Images.SetKeyName(3, "Globe_48x48.png");
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 227);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Name = "frmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj";
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMessage_KeyDown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMsgIcon)).EndInit();
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panelBottom;
        public System.Windows.Forms.ImageList imgList;
        public System.Windows.Forms.Label lblMessageTitle;
        public System.Windows.Forms.Label lblMessageCategory;
        public System.Windows.Forms.Label lblMesaj;
        public System.Windows.Forms.Button btnNo;
        public System.Windows.Forms.Button btnYes;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.PictureBox pbMsgIcon;
    }
}