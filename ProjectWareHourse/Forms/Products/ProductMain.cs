using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWareHourse.Forms.Products
{
    public partial class ProductMain : Form
    {
        public ProductMain()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
           int i = this.tableAdapterManager.UpdateAll(this.wareHouseDataSet);
            if (i > 0)
            {
                MessageBox.Show($"There is a {i} happend","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"There no changes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ProductMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wareHouseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.wareHouseDataSet.Products);

        }
    }
}
