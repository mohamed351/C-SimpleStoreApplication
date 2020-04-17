namespace ProjectWareHourse.Forms.Import_And_Export
{
    partial class SelectedFrm
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
            this.StoreCombo = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QtuNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpireDateCombo = new MetroFramework.Controls.MetroTextBox();
            this.ProductionCombo = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QtuNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreCombo
            // 
            this.StoreCombo.FormattingEnabled = true;
            this.StoreCombo.ItemHeight = 24;
            this.StoreCombo.Location = new System.Drawing.Point(230, 117);
            this.StoreCombo.Name = "StoreCombo";
            this.StoreCombo.Size = new System.Drawing.Size(366, 30);
            this.StoreCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity :";
            // 
            // QtuNumber
            // 
            this.QtuNumber.Location = new System.Drawing.Point(230, 196);
            this.QtuNumber.Name = "QtuNumber";
            this.QtuNumber.Size = new System.Drawing.Size(366, 22);
            this.QtuNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProductionDate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "ExpireDate :";
            // 
            // ExpireDateCombo
            // 
            this.ExpireDateCombo.Location = new System.Drawing.Point(230, 261);
            this.ExpireDateCombo.Name = "ExpireDateCombo";
            this.ExpireDateCombo.Size = new System.Drawing.Size(351, 23);
            this.ExpireDateCombo.TabIndex = 4;
            // 
            // ProductionCombo
            // 
            this.ProductionCombo.Location = new System.Drawing.Point(230, 335);
            this.ProductionCombo.Name = "ProductionCombo";
            this.ProductionCombo.Size = new System.Drawing.Size(351, 23);
            this.ProductionCombo.TabIndex = 4;
            // 
            // metroButton1
            // 
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.metroButton1.Location = new System.Drawing.Point(274, 390);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(265, 50);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Move It";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtMax
            // 
            this.txtMax.Enabled = false;
            this.txtMax.Location = new System.Drawing.Point(616, 195);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(228, 22);
            this.txtMax.TabIndex = 6;
            // 
            // SelectedFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 517);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ProductionCombo);
            this.Controls.Add(this.ExpireDateCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QtuNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoreCombo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectedFrm";
            this.Text = "SelectedFrm";
            ((System.ComponentModel.ISupportInitialize)(this.QtuNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox StoreCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown QtuNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox ExpireDateCombo;
        private MetroFramework.Controls.MetroTextBox ProductionCombo;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox txtMax;
    }
}