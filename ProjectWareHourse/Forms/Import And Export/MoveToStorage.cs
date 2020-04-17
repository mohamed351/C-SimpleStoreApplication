using ProjectWareHourse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ProjectWareHourse.ViewModel;

namespace ProjectWareHourse.Forms.Import_And_Export
{
    public partial class MoveToStorage : Form
    {
        WareHourseContext context = new WareHourseContext();

        public MoveToStorage()
        {
            InitializeComponent();

            comboBoxStore.DataSource = context.Stores.ToList();
            comboBoxStore.DisplayMember = "Name";
            comboBoxStore.ValueMember = "ID";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void comboBoxStore_SelectionChangeCommitted(object sender, EventArgs e)
        {

          
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SelectItems();

        }

        private void SelectItems()
        {
            int ID = Convert.ToInt32(comboBoxStore.SelectedValue);
            dataGridView1.DataSource = context.ProductStores
                .Include(async => async.Product)
                .Include(a => a.Store).Where(a => a.StoreID == ID && a.Qtu != 0)
                .Select(a => new DataStoreViewModel() { ID = a.ID, ProductID = a.ProductID, SourceStorage = a.Store.Name, Name = a.Product.Name, StoreID = a.Store.ID, ProductDate = a.ProductDate, ExpireDate = a.ExpireDate, Qtu = a.Qtu }).ToList();
            dataGridView1.Columns["StoreID"].Visible = false;
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["SourceStorage"].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows != null)
            {
             
                DataStoreViewModel type = (DataStoreViewModel)dataGridView1.SelectedRows[0].DataBoundItem;
                SelectedFrm frm = new SelectedFrm(type);
               if(frm.ShowDialog() == DialogResult.OK)
                {
                    SelectItems();
                }




            }
        }
    }
}
