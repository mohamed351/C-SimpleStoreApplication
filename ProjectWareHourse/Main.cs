using ProjectWareHourse.Forms.Customers;
using ProjectWareHourse.Forms.Import_And_Export;
using ProjectWareHourse.Forms.Products;
using ProjectWareHourse.Forms.ProductStores;
using ProjectWareHourse.Forms.Stores;
using ProjectWareHourse.Forms.Supplier;
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

namespace ProjectWareHourse
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerMain main = new CustomerMain();
            main.ShowDialog();

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SupplierMain frm = new SupplierMain();
            frm.ShowDialog();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            StoreMain frm = new StoreMain();
            frm.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ProductMain frm = new ProductMain();
            frm.ShowDialog();
        }

        private void btnImports_Click(object sender, EventArgs e)
        {
            storage storage = new storage();
            storage.ShowDialog();
        }

        private void btnExports_Click(object sender, EventArgs e)
        {
            frmExport frmExport = new frmExport();
            frmExport.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ProductSore productSore = new ProductSore();
            productSore.ShowDialog();



        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            MoveToStorage toStorage = new MoveToStorage();
            toStorage.ShowDialog();

        }
    }
}
