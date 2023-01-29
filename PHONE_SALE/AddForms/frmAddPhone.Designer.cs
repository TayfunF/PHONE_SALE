namespace PHONE_SALE
{
    partial class frmAddPhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPhone));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImeiNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageListAddProduction = new System.Windows.Forms.ImageList(this.components);
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brand_Model_DataSet = new PHONE_SALE.Brand_Model_DataSet();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.fKModelBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new PHONE_SALE.Brand_Model_DataSetTableAdapters.BrandTableAdapter();
            this.modelTableAdapter = new PHONE_SALE.Brand_Model_DataSetTableAdapters.ModelTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_Model_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelBrandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seri No :";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSerialNumber.Location = new System.Drawing.Point(97, 134);
            this.txtSerialNumber.MaxLength = 15;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(191, 21);
            this.txtSerialNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "İmei No :";
            // 
            // txtImeiNumber
            // 
            this.txtImeiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImeiNumber.Location = new System.Drawing.Point(97, 168);
            this.txtImeiNumber.MaxLength = 15;
            this.txtImeiNumber.Name = "txtImeiNumber";
            this.txtImeiNumber.Size = new System.Drawing.Size(191, 21);
            this.txtImeiNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Üretim Tarihi :";
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpProductionDate.Location = new System.Drawing.Point(97, 198);
            this.dtpProductionDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(191, 20);
            this.dtpProductionDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alış Tarihi :";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(97, 231);
            this.dtpPurchaseDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(193, 20);
            this.dtpPurchaseDate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(29, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Alış Fiyatı : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Satış Fiyatı : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(553, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kdv % :";
            // 
            // txtCPU
            // 
            this.txtCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCPU.Location = new System.Drawing.Point(603, 130);
            this.txtCPU.MaxLength = 15;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(193, 21);
            this.txtCPU.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(549, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "İşlemci :";
            // 
            // txtMemory
            // 
            this.txtMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMemory.Location = new System.Drawing.Point(603, 194);
            this.txtMemory.MaxLength = 15;
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.Size = new System.Drawing.Size(193, 21);
            this.txtMemory.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(553, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Hafıza :";
            // 
            // txtResolution
            // 
            this.txtResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResolution.Location = new System.Drawing.Point(603, 230);
            this.txtResolution.MaxLength = 15;
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(193, 21);
            this.txtResolution.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(526, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Çözünürlük :";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtColor.Location = new System.Drawing.Point(603, 266);
            this.txtColor.MaxLength = 15;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(193, 21);
            this.txtColor.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(556, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Renk : ";
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileDialog.Location = new System.Drawing.Point(334, 226);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(153, 33);
            this.btnFileDialog.TabIndex = 17;
            this.btnFileDialog.Text = "Resim Seç";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageKey = "Check_32x32.png";
            this.btnSave.ImageList = this.imageListAddProduction;
            this.btnSave.Location = new System.Drawing.Point(355, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 53);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imageListAddProduction
            // 
            this.imageListAddProduction.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAddProduction.ImageStream")));
            this.imageListAddProduction.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAddProduction.Images.SetKeyName(0, "Check_32x32.png");
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOS.Location = new System.Drawing.Point(603, 164);
            this.txtOS.MaxLength = 15;
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(193, 21);
            this.txtOS.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(508, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "İşletim Sistemi :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogImage";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(317, 70);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(179, 138);
            this.pictureBoxImage.TabIndex = 32;
            this.pictureBoxImage.TabStop = false;
            // 
            // cbBrand
            // 
            this.cbBrand.DataSource = this.brandBindingSource;
            this.cbBrand.DisplayMember = "Brand";
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(97, 62);
            this.cbBrand.MaxLength = 15;
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(191, 23);
            this.cbBrand.TabIndex = 1;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.brand_Model_DataSet;
            // 
            // brand_Model_DataSet
            // 
            this.brand_Model_DataSet.DataSetName = "Brand_Model_DataSet";
            this.brand_Model_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbModel
            // 
            this.cbModel.DataSource = this.fKModelBrandBindingSource;
            this.cbModel.DisplayMember = "Model";
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(97, 101);
            this.cbModel.MaxLength = 15;
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(191, 23);
            this.cbModel.TabIndex = 3;
            // 
            // fKModelBrandBindingSource
            // 
            this.fKModelBrandBindingSource.DataMember = "FK_Model_Brand";
            this.fKModelBrandBindingSource.DataSource = this.brandBindingSource;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(549, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Miktar :";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(97, 266);
            this.txtPurchasePrice.MaxLength = 15;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(191, 21);
            this.txtPurchasePrice.TabIndex = 13;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(604, 67);
            this.txtAmount.MaxLength = 15;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(191, 21);
            this.txtAmount.TabIndex = 19;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalePrice.Location = new System.Drawing.Point(97, 299);
            this.txtSalePrice.MaxLength = 15;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(191, 21);
            this.txtSalePrice.TabIndex = 15;
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVat.Location = new System.Drawing.Point(602, 99);
            this.txtVat.MaxLength = 15;
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(53, 21);
            this.txtVat.TabIndex = 21;
            this.txtVat.Text = "1";
            // 
            // frmAddPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(808, 375);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFileDialog);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtResolution);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMemory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpPurchaseDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpProductionDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtImeiNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddPhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.frmAddPhone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_Model_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelBrandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImeiNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imageListAddProduction;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbModel;
        private Brand_Model_DataSet brand_Model_DataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private Brand_Model_DataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource fKModelBrandBindingSource;
        private Brand_Model_DataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtVat;
    }
}