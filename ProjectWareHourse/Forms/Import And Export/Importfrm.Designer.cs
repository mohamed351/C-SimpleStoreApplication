namespace ProjectWareHourse.Forms.Import_And_Export
{
    partial class storage
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
            this.lablType = new MetroFramework.Controls.MetroLabel();
            this.comboSupplierAndCustomer = new MetroFramework.Controls.MetroComboBox();
            this.comboStorage = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtProductCode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQutity = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.productionDate = new System.Windows.Forms.DateTimePicker();
            this.expireDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProduct = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQutity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lablType
            // 
            this.lablType.AutoSize = true;
            this.lablType.Location = new System.Drawing.Point(179, 48);
            this.lablType.Name = "lablType";
            this.lablType.Size = new System.Drawing.Size(66, 20);
            this.lablType.TabIndex = 4;
            this.lablType.Text = "Supplier :";
            // 
            // comboSupplierAndCustomer
            // 
            this.comboSupplierAndCustomer.FormattingEnabled = true;
            this.comboSupplierAndCustomer.ItemHeight = 24;
            this.comboSupplierAndCustomer.Location = new System.Drawing.Point(279, 48);
            this.comboSupplierAndCustomer.Name = "comboSupplierAndCustomer";
            this.comboSupplierAndCustomer.Size = new System.Drawing.Size(184, 30);
            this.comboSupplierAndCustomer.TabIndex = 5;
            // 
            // comboStorage
            // 
            this.comboStorage.FormattingEnabled = true;
            this.comboStorage.ItemHeight = 24;
            this.comboStorage.Location = new System.Drawing.Point(619, 48);
            this.comboStorage.Name = "comboStorage";
            this.comboStorage.Size = new System.Drawing.Size(262, 30);
            this.comboStorage.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(485, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 20);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "StorageName :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(76, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 20);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Product-Code :";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(255, 105);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(365, 23);
            this.txtProductCode.TabIndex = 9;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQutity);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.productionDate);
            this.groupBox1.Controls.Add(this.expireDate);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(167, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 114);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SupplmentInformation";
            // 
            // txtQutity
            // 
            this.txtQutity.Location = new System.Drawing.Point(169, 40);
            this.txtQutity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtQutity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQutity.Name = "txtQutity";
            this.txtQutity.Size = new System.Drawing.Size(87, 22);
            this.txtQutity.TabIndex = 14;
            this.txtQutity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(321, 61);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(112, 20);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "ProductionDate :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(350, 21);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 20);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "ExpireDate :";
            // 
            // productionDate
            // 
            this.productionDate.Location = new System.Drawing.Point(482, 61);
            this.productionDate.Name = "productionDate";
            this.productionDate.Size = new System.Drawing.Size(320, 22);
            this.productionDate.TabIndex = 11;
            // 
            // expireDate
            // 
            this.expireDate.Location = new System.Drawing.Point(482, 21);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(320, 22);
            this.expireDate.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(74, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Quantity :";
            // 
            // metroButton1
            // 
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(813, 276);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 35);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Add";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Enabled = false;
            this.metroButton2.Location = new System.Drawing.Point(950, 276);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(115, 35);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "Delete";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(898, 257);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(638, 105);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(405, 23);
            this.txtProduct.TabIndex = 13;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(960, 614);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(194, 51);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Submit";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 677);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.comboStorage);
            this.Controls.Add(this.comboSupplierAndCustomer);
            this.Controls.Add(this.lablType);
            this.Name = "storage";
            this.Text = "ImportAndExport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQutity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lablType;
        private MetroFramework.Controls.MetroComboBox comboSupplierAndCustomer;
        private MetroFramework.Controls.MetroComboBox comboStorage;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtProductCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker productionDate;
        private System.Windows.Forms.DateTimePicker expireDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtProduct;
        private System.Windows.Forms.NumericUpDown txtQutity;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}