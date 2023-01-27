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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductions)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductions.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductions.RowHeadersVisible = false;
            this.dataGridViewProductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductions.Size = new System.Drawing.Size(1254, 704);
            this.dataGridViewProductions.TabIndex = 0;
            this.dataGridViewProductions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductions_CellDoubleClick);
            // 
            // frmPhoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 704);
            this.Controls.Add(this.dataGridViewProductions);
            this.Name = "frmPhoneList";
            this.Text = "Telefon Listesi";
            this.Load += new System.EventHandler(this.frmPhoneList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewProductions;
    }
}