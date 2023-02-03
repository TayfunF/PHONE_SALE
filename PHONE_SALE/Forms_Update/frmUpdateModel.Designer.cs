namespace PHONE_SALE.Forms_Update
{
    partial class frmUpdateModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateModel));
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brand_Model_DataSet = new PHONE_SALE.Brand_Model_DataSet();
            this.brandTableAdapter = new PHONE_SALE.Brand_Model_DataSetTableAdapters.BrandTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.fKModelBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new PHONE_SALE.Brand_Model_DataSetTableAdapters.ModelTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblId = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_Model_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelBrandBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model :";
            // 
            // fKModelBrandBindingSource
            // 
            this.fKModelBrandBindingSource.DataMember = "FK_Model_Brand";
            this.fKModelBrandBindingSource.DataSource = this.brandBindingSource;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageKey = "check.png";
            this.btnUpdate.ImageList = this.ımageList1;
            this.btnUpdate.Location = new System.Drawing.Point(69, 61);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 38);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "busy.png");
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(21, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(59, 25);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(178, 22);
            this.txtModel.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "busy.png";
            this.btnDelete.ImageList = this.ımageList1;
            this.btnDelete.Location = new System.Drawing.Point(164, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 38);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUpdateModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 115);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Name = "frmUpdateModel";
            this.Text = "Model Güncelle";
            this.Load += new System.EventHandler(this.frmUpdateModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brand_Model_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelBrandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Brand_Model_DataSet brand_Model_DataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private Brand_Model_DataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource fKModelBrandBindingSource;
        private Brand_Model_DataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnDelete;
    }
}