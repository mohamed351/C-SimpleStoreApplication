using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWareHourse.Forms.Stores
{
    public partial class StoreMain : Form
    {
        public StoreMain()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void StoreMain_Load(object sender, EventArgs e)
        {
         
          this.storesTableAdapter.Fill(this.wareHouseDataSet.Stores);
           
        }

        private void storesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storesBindingSource.EndEdit();
           int changes =  this.tableAdapterManager.UpdateAll(this.wareHouseDataSet);

            if (changes > 0)
            {
                MessageBox.Show($"There are {changes} happend", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no changes happend ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
