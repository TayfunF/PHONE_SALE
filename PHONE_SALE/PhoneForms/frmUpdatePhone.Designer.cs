namespace PHONE_SALE.PhoneForms
{
    partial class frmUpdatePhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePhone));
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.fKModelBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brand_Model_DataSet = new PHONE_SALE.Brand_Model_DataSet();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtImeiNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageListUpdatePhone = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.brandTableAdapter = new PHONE_SALE.Brand_Model_DataSetTableAdapters.BrandTableAdapter();
            this.modelTableAdapter = new PHONE_SALE.Brand_Model_DataSetTableAdapters.ModelTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdateBrandModel = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_Model_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModel
            // 
            this.cbModel.DataSource = this.fKModelBrandBindingSource;
            this.cbModel.DisplayMember = "Model";
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(98, 64);
            this.cbModel.MaxLength = 15;
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(191, 23);
            this.cbModel.TabIndex = 92;
            // 
            // fKModelBrandBindingSource
            // 
            this.fKModelBrandBindingSource.DataMember = "FK_Model_Brand";
            this.fKModelBrandBindingSource.DataSource = this.brandBindingSource;
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
            // cbBrand
            // 
            this.cbBrand.DataSource = this.brandBindingSource;
            this.cbBrand.DisplayMember = "Brand";
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(98, 23);
            this.cbBrand.MaxLength = 15;
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(191, 23);
            this.cbBrand.TabIndex = 90;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(338, 31);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(179, 138);
            this.pictureBoxImage.TabIndex = 119;
            this.pictureBoxImage.TabStop = false;
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOS.Location = new System.Drawing.Point(99, 404);
            this.txtOS.MaxLength = 15;
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(193, 21);
            this.txtOS.TabIndex = 114;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(4, 408);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 15);
            this.label15.TabIndex = 109;
            this.label15.Text = "İşletim Sistemi :";
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileDialog.Location = new System.Drawing.Point(355, 187);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(153, 33);
            this.btnFileDialog.TabIndex = 106;
            this.btnFileDialog.Text = "Resim Seç";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtColor.Location = new System.Drawing.Point(99, 506);
            this.txtColor.MaxLength = 15;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(193, 21);
            this.txtColor.TabIndex = 118;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(52, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 115;
            this.label13.Text = "Renk : ";
            // 
            // txtResolution
            // 
            this.txtResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResolution.Location = new System.Drawing.Point(99, 470);
            this.txtResolution.MaxLength = 15;
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(193, 21);
            this.txtResolution.TabIndex = 117;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(22, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 113;
            this.label12.Text = "Çözünürlük :";
            // 
            // txtMemory
            // 
            this.txtMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMemory.Location = new System.Drawing.Point(99, 434);
            this.txtMemory.MaxLength = 15;
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.Size = new System.Drawing.Size(193, 21);
            this.txtMemory.TabIndex = 116;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(49, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 111;
            this.label11.Text = "Hafıza :";
            // 
            // txtCPU
            // 
            this.txtCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCPU.Location = new System.Drawing.Point(99, 370);
            this.txtCPU.MaxLength = 15;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(193, 21);
            this.txtCPU.TabIndex = 112;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(45, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 107;
            this.label10.Text = "İşlemci :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(49, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 105;
            this.label9.Text = "Kdv % :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 103;
            this.label8.Text = "Satış Fiyatı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 101;
            this.label7.Text = "Alış Fiyatı : ";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(98, 200);
            this.dtpPurchaseDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(193, 20);
            this.dtpPurchaseDate.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 99;
            this.label6.Text = "Alış Tarihi :";
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpProductionDate.Location = new System.Drawing.Point(98, 167);
            this.dtpProductionDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(191, 20);
            this.dtpProductionDate.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 97;
            this.label5.Text = "Üretim Tarihi :";
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVat.Location = new System.Drawing.Point(98, 339);
            this.txtVat.MaxLength = 15;
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(53, 21);
            this.txtVat.TabIndex = 110;
            this.txtVat.Text = "1";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalePrice.Location = new System.Drawing.Point(99, 273);
            this.txtSalePrice.MaxLength = 15;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(191, 21);
            this.txtSalePrice.TabIndex = 108;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(98, 235);
            this.txtPurchasePrice.MaxLength = 15;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(191, 21);
            this.txtPurchasePrice.TabIndex = 102;
            // 
            // txtImeiNumber
            // 
            this.txtImeiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImeiNumber.Location = new System.Drawing.Point(98, 137);
            this.txtImeiNumber.MaxLength = 15;
            this.txtImeiNumber.Name = "txtImeiNumber";
            this.txtImeiNumber.Size = new System.Drawing.Size(191, 21);
            this.txtImeiNumber.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 95;
            this.label4.Text = "İmei No :";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSerialNumber.Location = new System.Drawing.Point(98, 107);
            this.txtSerialNumber.MaxLength = 15;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(191, 21);
            this.txtSerialNumber.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 93;
            this.label3.Text = "Seri No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "Model :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 89;
            this.label1.Text = "Marka :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageKey = "busy.png";
            this.btnDelete.ImageList = this.imageListUpdatePhone;
            this.btnDelete.Location = new System.Drawing.Point(469, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 46);
            this.btnDelete.TabIndex = 88;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // imageListUpdatePhone
            // 
            this.imageListUpdatePhone.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListUpdatePhone.ImageStream")));
            this.imageListUpdatePhone.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListUpdatePhone.Images.SetKeyName(0, "check.png");
            this.imageListUpdatePhone.Images.SetKeyName(1, "busy.png");
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.ImageKey = "check.png";
            this.btnUpdate.ImageList = this.imageListUpdatePhone;
            this.btnUpdate.Location = new System.Drawing.Point(338, 490);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 46);
            this.btnUpdate.TabIndex = 87;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(43, 2);
            this.txtId.MaxLength = 15;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(49, 21);
            this.txtId.TabIndex = 121;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(12, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 15);
            this.lblId.TabIndex = 122;
            this.lblId.Text = "Id :";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(100, 308);
            this.txtAmount.MaxLength = 15;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(191, 21);
            this.txtAmount.TabIndex = 104;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(45, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 120;
            this.label14.Text = "Miktar :";
            // 
            // btnUpdateBrandModel
            // 
            this.btnUpdateBrandModel.BackColor = System.Drawing.Color.Green;
            this.btnUpdateBrandModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBrandModel.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBrandModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateBrandModel.ImageKey = "check.png";
            this.btnUpdateBrandModel.ImageList = this.imageListUpdatePhone;
            this.btnUpdateBrandModel.Location = new System.Drawing.Point(338, 418);
            this.btnUpdateBrandModel.Name = "btnUpdateBrandModel";
            this.btnUpdateBrandModel.Size = new System.Drawing.Size(210, 53);
            this.btnUpdateBrandModel.TabIndex = 85;
            this.btnUpdateBrandModel.Text = "Marka Model Güncelle";
            this.btnUpdateBrandModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateBrandModel.UseVisualStyleBackColor = false;
            this.btnUpdateBrandModel.Click += new System.EventHandler(this.btnUpdateBrandModel_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrand.ForeColor = System.Drawing.Color.Green;
            this.lblBrand.Location = new System.Drawing.Point(97, 46);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(79, 15);
            this.lblBrand.TabIndex = 123;
            this.lblBrand.Text = "Yeni Marka";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.ForeColor = System.Drawing.Color.Green;
            this.lblModel.Location = new System.Drawing.Point(98, 88);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(79, 15);
            this.lblModel.TabIndex = 124;
            this.lblModel.Text = "Yeni Model";
            // 
            // frmUpdatePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(572, 548);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.label15);
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
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpdateBrandModel);
            this.Name = "frmUpdatePhone";
            this.Text = "Telefon Güncelle";
            this.Load += new System.EventHandler(this.frmUpdatePhone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKModelBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_Model_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ImageList imageListUpdatePhone;
        public System.Windows.Forms.ComboBox cbBrand;
        public System.Windows.Forms.ComboBox cbModel;
        public System.Windows.Forms.TextBox txtSerialNumber;
        public System.Windows.Forms.TextBox txtImeiNumber;
        public System.Windows.Forms.DateTimePicker dtpProductionDate;
        public System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        public System.Windows.Forms.TextBox txtOS;
        public System.Windows.Forms.TextBox txtColor;
        public System.Windows.Forms.TextBox txtResolution;
        public System.Windows.Forms.TextBox txtMemory;
        public System.Windows.Forms.TextBox txtCPU;
        public System.Windows.Forms.TextBox txtVat;
        public System.Windows.Forms.TextBox txtSalePrice;
        public System.Windows.Forms.TextBox txtPurchasePrice;
        private Brand_Model_DataSet brand_Model_DataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private Brand_Model_DataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource fKModelBrandBindingSource;
        private Brand_Model_DataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button btnFileDialog;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUpdateBrandModel;
        public System.Windows.Forms.Label lblBrand;
        public System.Windows.Forms.Label lblModel;
    }
}