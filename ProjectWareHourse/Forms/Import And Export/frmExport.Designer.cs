namespace ProjectWareHourse.Forms.Import_And_Export
{
    partial class frmExport
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
            this.comboCustomer = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboStore = new MetroFramework.Controls.MetroComboBox();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumricUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxQuantity = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumricUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCustomer
            // 
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.ItemHeight = 24;
            this.comboCustomer.Location = new System.Drawing.Point(192, 40);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(291, 30);
            this.comboCustomer.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(52, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Customers :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(543, 38);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "StoreName :";
            // 
            // comboStore
            // 
            this.comboStore.FormattingEnabled = true;
            this.comboStore.ItemHeight = 24;
            this.comboStore.Location = new System.Drawing.Point(704, 32);
            this.comboStore.Name = "comboStore";
            this.comboStore.Size = new System.Drawing.Size(291, 30);
            this.comboStore.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(236, 108);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(306, 23);
            this.txtCode.TabIndex = 4;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity  :";
            // 
            // txtNumricUpDown
            // 
            this.txtNumricUpDown.Location = new System.Drawing.Point(721, 109);
            this.txtNumricUpDown.Name = "txtNumricUpDown";
            this.txtNumricUpDown.Size = new System.Drawing.Size(84, 22);
            this.txtNumricUpDown.TabIndex = 7;
            this.txtNumricUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumricUpDown_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(954, 384);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(236, 152);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(306, 23);
            this.txtProductName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Max Quantity :";
            // 
            // maxQuantity
            // 
            this.maxQuantity.Enabled = false;
            this.maxQuantity.Location = new System.Drawing.Point(722, 142);
            this.maxQuantity.Name = "maxQuantity";
            this.maxQuantity.Size = new System.Drawing.Size(83, 23);
            this.maxQuantity.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNumricUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.comboStore);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.comboCustomer);
            this.Name = "frmExport";
            this.Text = "frmExport";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumricUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox comboCustomer;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox comboStore;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNumricUpDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox maxQuantity;
        private System.Windows.Forms.Button button1;
    }
}