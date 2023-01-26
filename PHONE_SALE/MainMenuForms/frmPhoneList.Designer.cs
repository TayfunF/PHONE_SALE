namespace PHONE_SALE.MainMenuForms
{
    partial class frmPhoneList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductions = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdateBrandModel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtImeiNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductions)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductions
            // 
            this.dataGridViewProductions.AllowUserToAddRows = false;
            this.dataGridViewProductions.AllowUserToDeleteRows = false;
            this.dataGridViewProductions.AllowUserToOrderColumns = true;
            this.dataGridViewProductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewProductions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewProductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductions.MultiSelect = false;
            this.dataGridViewProductions.Name = "dataGridViewProductions";
            this.dataGridViewProductions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductions.RowHeadersVisible = false;
            this.dataGridViewProductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductions.Size = new System.Drawing.Size(1201, 729);
            this.dataGridViewProductions.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.txtOS);
            this.panelBottom.Controls.Add(this.label15);
            this.panelBottom.Controls.Add(this.txtColor);
            this.panelBottom.Controls.Add(this.label13);
            this.panelBottom.Controls.Add(this.txtResolution);
            this.panelBottom.Controls.Add(this.label12);
            this.panelBottom.Controls.Add(this.txtMemory);
            this.panelBottom.Controls.Add(this.label11);
            this.panelBottom.Controls.Add(this.txtCPU);
            this.panelBottom.Controls.Add(this.label10);
            this.panelBottom.Controls.Add(this.label9);
            this.panelBottom.Controls.Add(this.label8);
            this.panelBottom.Controls.Add(this.txtVat);
            this.panelBottom.Controls.Add(this.txtSalePrice);
            this.panelBottom.Controls.Add(this.label14);
            this.panelBottom.Controls.Add(this.cbModel);
            this.panelBottom.Controls.Add(this.cbBrand);
            this.panelBottom.Controls.Add(this.label7);
            this.panelBottom.Controls.Add(this.dtpPurchaseDate);
            this.panelBottom.Controls.Add(this.label6);
            this.panelBottom.Controls.Add(this.dtpProductionDate);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Controls.Add(this.txtAmount);
            this.panelBottom.Controls.Add(this.txtPurchasePrice);
            this.panelBottom.Controls.Add(this.txtImeiNumber);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.txtSerialNumber);
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.btnDelete);
            this.panelBottom.Controls.Add(this.btnUpdate);
            this.panelBottom.Controls.Add(this.label16);
            this.panelBottom.Controls.Add(this.txtSearch);
            this.panelBottom.Controls.Add(this.btnUpdateBrandModel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 458);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1201, 271);
            this.panelBottom.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "Check_32x32.png";
            this.btnDelete.Location = new System.Drawing.Point(594, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 46);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageKey = "Check_32x32.png";
            this.btnUpdate.Location = new System.Drawing.Point(594, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 46);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(761, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 15);
            this.label16.TabIndex = 49;
            this.label16.Text = "BÜYÜTEÇ İMAGE KOY";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(898, 17);
            this.txtSearch.MaxLength = 100;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 21);
            this.txtSearch.TabIndex = 48;
            // 
            // btnUpdateBrandModel
            // 
            this.btnUpdateBrandModel.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateBrandModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBrandModel.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBrandModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateBrandModel.ImageKey = "Check_32x32.png";
            this.btnUpdateBrandModel.Location = new System.Drawing.Point(594, 38);
            this.btnUpdateBrandModel.Name = "btnUpdateBrandModel";
            this.btnUpdateBrandModel.Size = new System.Drawing.Size(142, 46);
            this.btnUpdateBrandModel.TabIndex = 44;
            this.btnUpdateBrandModel.Text = "Marka Model Güncelle";
            this.btnUpdateBrandModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateBrandModel.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(37, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 67;
            this.label14.Text = "Miktar :";
            // 
            // cbModel
            // 
            this.cbModel.DisplayMember = "Model";
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(92, 42);
            this.cbModel.MaxLength = 15;
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(191, 23);
            this.cbModel.TabIndex = 55;
            // 
            // cbBrand
            // 
            this.cbBrand.DisplayMember = "Brand";
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(92, 3);
            this.cbBrand.MaxLength = 15;
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(191, 23);
            this.cbBrand.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Alış Fiyatı : ";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(92, 172);
            this.dtpPurchaseDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(193, 20);
            this.dtpPurchaseDate.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 62;
            this.label6.Text = "Alış Tarihi :";
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpProductionDate.Location = new System.Drawing.Point(92, 139);
            this.dtpProductionDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(191, 20);
            this.dtpProductionDate.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Üretim Tarihi :";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(92, 239);
            this.txtAmount.MaxLength = 15;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(191, 21);
            this.txtAmount.TabIndex = 66;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(92, 207);
            this.txtPurchasePrice.MaxLength = 15;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(191, 21);
            this.txtPurchasePrice.TabIndex = 65;
            // 
            // txtImeiNumber
            // 
            this.txtImeiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImeiNumber.Location = new System.Drawing.Point(92, 109);
            this.txtImeiNumber.MaxLength = 15;
            this.txtImeiNumber.Name = "txtImeiNumber";
            this.txtImeiNumber.Size = new System.Drawing.Size(191, 21);
            this.txtImeiNumber.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "İmei No :";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSerialNumber.Location = new System.Drawing.Point(92, 75);
            this.txtSerialNumber.MaxLength = 15;
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(191, 21);
            this.txtSerialNumber.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Seri No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Model :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Marka :";
            // 
            // txtOS
            // 
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOS.Location = new System.Drawing.Point(387, 120);
            this.txtOS.MaxLength = 15;
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(193, 21);
            this.txtOS.TabIndex = 77;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(292, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 15);
            this.label15.TabIndex = 72;
            this.label15.Text = "İşletim Sistemi :";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtColor.Location = new System.Drawing.Point(387, 222);
            this.txtColor.MaxLength = 15;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(193, 21);
            this.txtColor.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(340, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 78;
            this.label13.Text = "Renk : ";
            // 
            // txtResolution
            // 
            this.txtResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResolution.Location = new System.Drawing.Point(387, 186);
            this.txtResolution.MaxLength = 15;
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(193, 21);
            this.txtResolution.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(310, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 76;
            this.label12.Text = "Çözünürlük :";
            // 
            // txtMemory
            // 
            this.txtMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMemory.Location = new System.Drawing.Point(387, 150);
            this.txtMemory.MaxLength = 15;
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.Size = new System.Drawing.Size(193, 21);
            this.txtMemory.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(337, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 74;
            this.label11.Text = "Hafıza :";
            // 
            // txtCPU
            // 
            this.txtCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCPU.Location = new System.Drawing.Point(387, 86);
            this.txtCPU.MaxLength = 15;
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(193, 21);
            this.txtCPU.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(333, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 70;
            this.label10.Text = "İşlemci :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(337, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 69;
            this.label9.Text = "Kdv % :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(310, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 68;
            this.label8.Text = "Satış Fiyatı : ";
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVat.Location = new System.Drawing.Point(386, 55);
            this.txtVat.MaxLength = 15;
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(53, 21);
            this.txtVat.TabIndex = 73;
            this.txtVat.Text = "1";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalePrice.Location = new System.Drawing.Point(386, 20);
            this.txtSalePrice.MaxLength = 15;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(191, 21);
            this.txtSalePrice.TabIndex = 71;
            // 
            // frmPhoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 729);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dataGridViewProductions);
            this.Name = "frmPhoneList";
            this.Text = "Telefon Listesi";
            this.Load += new System.EventHandler(this.frmPhoneList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductions)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductions;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdateBrandModel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtImeiNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtResolution;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtSalePrice;
    }
}