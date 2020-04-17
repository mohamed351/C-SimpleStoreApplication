namespace ProjectWareHourse.Forms.Customers
{
    partial class CustomerMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.groupForm = new System.Windows.Forms.GroupBox();
            this.txtwebsite = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFax = new MetroFramework.Controls.MetroTextBox();
            this.txtphone = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(385, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 433);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(185, 49);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Add";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(364, 433);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(185, 49);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Edit";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(721, 433);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(185, 49);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Delete";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // groupForm
            // 
            this.groupForm.Controls.Add(this.txtwebsite);
            this.groupForm.Controls.Add(this.metroLabel4);
            this.groupForm.Controls.Add(this.metroLabel3);
            this.groupForm.Controls.Add(this.metroLabel2);
            this.groupForm.Controls.Add(this.metroLabel1);
            this.groupForm.Controls.Add(this.txtFax);
            this.groupForm.Controls.Add(this.txtphone);
            this.groupForm.Controls.Add(this.txtName);
            this.groupForm.Location = new System.Drawing.Point(23, 105);
            this.groupForm.Name = "groupForm";
            this.groupForm.Size = new System.Drawing.Size(343, 188);
            this.groupForm.TabIndex = 2;
            this.groupForm.TabStop = false;
            this.groupForm.Text = "Imformation";
            // 
            // txtwebsite
            // 
            this.txtwebsite.Location = new System.Drawing.Point(83, 136);
            this.txtwebsite.Name = "txtwebsite";
            this.txtwebsite.Size = new System.Drawing.Size(178, 23);
            this.txtwebsite.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 136);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Website :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 20);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Fax :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Phone:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Name :";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(83, 106);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(178, 23);
            this.txtFax.TabIndex = 2;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(83, 74);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(178, 23);
            this.txtphone.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 23);
            this.txtName.TabIndex = 0;
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 505);
            this.Controls.Add(this.groupForm);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerMain";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupForm.ResumeLayout(false);
            this.groupForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.GroupBox groupForm;
        private MetroFramework.Controls.MetroTextBox txtwebsite;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtFax;
        private MetroFramework.Controls.MetroTextBox txtphone;
        private MetroFramework.Controls.MetroTextBox txtName;
    }
}