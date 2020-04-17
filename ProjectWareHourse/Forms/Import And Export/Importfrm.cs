using ProjectWareHourse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWareHourse.Forms.Import_And_Export
{
    public partial class storage : Form
    {
        WareHourseContext context = new WareHourseContext();
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        ICollection<ProductStore> stores;
        DataTable DataTable;
        public storage()
        {
            InitializeComponent();
          
            comboSupplierAndCustomer.DataSource = context.People.Where(a => a.Type == TypeOfPerson.Supplier && !a.IsDeleted).ToList();
            comboSupplierAndCustomer.DisplayMember = "Name";
            comboSupplierAndCustomer.ValueMember = "ID";

            comboStorage.DataSource = context.Stores.ToList();
            comboStorage.DisplayMember  = "Name";
            comboStorage.ValueMember = "ID";

            dataGridView1.Columns.Add("ProductID", "ProductID");
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns.Add("ProductName", "ProductName");
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns.Add("Qtu", "Qtu");
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns.Add("ExpireDateProduct", "ExpireDateProduct");
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns.Add("ProductionDate", "ProductionDate");
            dataGridView1.Columns[4].ReadOnly = true;

            DataTable = new DataTable();
            DataTable.Columns.Add("ProductID");
            DataTable.Columns.Add("Qtu");
            DataTable.Columns.Add("ExpireDate");
            DataTable.Columns.Add("ProductionDate");
            




        }

        private void comboType_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode  == Keys.Enter)
            {
               Product product =  context.Products.FirstOrDefault(a => a.Code == txtProductCode.Text);
                if(product != null)
                {

                    stores = product.ProductStores;
                    txtProduct.Text = product.Name;
                    ProductName = product.Name;
                    groupBox1.Enabled = true;
                    metroButton1.Enabled = true;
                    metroButton2.Enabled = true;
                    this.ProductID = product.ID;


                }
                else
                {
                    MessageBox.Show("Product Doesn't Exist");
                }
            }
        }
        private int  GetIndex()
        {
            int index = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == ProductID)
                {
                    return i;
                }

            }
            return index;
        } 

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int index = GetIndex();
            if (index == -1)
            {
                dataGridView1.Rows.Add(ProductID, ProductName, txtQutity.Value, expireDate.Value.Date.ToShortDateString(), productionDate.Value.Date.ToShortDateString());
            }
            else
            {
                double qtu = Convert.ToDouble(dataGridView1.Rows[index].Cells["Qtu"].Value);
                qtu += Convert.ToDouble(txtQutity.Value);
                dataGridView1.Rows[index].Cells["Qtu"].Value = qtu;

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            List<OrderDetails> list = new List<OrderDetails>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                list.Add(new OrderDetails()
                {
                    ProductID = Convert.ToInt32(item.Cells[0].Value),
                    Qtu = Convert.ToInt32(item.Cells[2].Value),
                    ProductionDate = Convert.ToDateTime(item.Cells[4].Value),
                    ExpireDateProduct = Convert.ToDateTime(item.Cells[3].Value),



                });
            }
            Order order = new Order()
            {
                PersonID = Convert.ToInt32(comboSupplierAndCustomer.SelectedValue),
                StorageName = comboStorage.Text,
                DateOfOperation = DateTime.Now,
                TypeOf = TypeOfOrders.Import,
                OrderDetails = list
               
               
               
            };
            List<ProductStore> productStores = new List<ProductStore>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                int productId = Convert.ToInt32(item.Cells[0].Value);
                DateTime Exdate = Convert.ToDateTime(item.Cells[3].Value);
                DateTime Prdate = Convert.ToDateTime(item.Cells[4].Value);
                int StorageId = Convert.ToInt32(comboStorage.SelectedValue);
                var items = context.ProductStores.Where(a => a.ProductID == productId && DbFunctions.TruncateTime(a.ExpireDate) == Exdate.Date &&
                DbFunctions.TruncateTime(a.ProductDate) == Prdate.Date && a.StoreID == StorageId
                ).ToList();
                if (items.Count == 0)
                {
                    productStores.Add(new ProductStore()
                    {
                        ExpireDate = Convert.ToDateTime(item.Cells[3].Value),
                        ProductDate = Convert.ToDateTime(item.Cells[4].Value),
                        Qtu = Convert.ToInt32(item.Cells[2].Value),
                        ProductID = Convert.ToInt32(item.Cells[0].Value),
                        StoreID = Convert.ToInt32(comboStorage.SelectedValue)

                    });
                }
                else
                {

                    ProductStore currentProduct = context.ProductStores.FirstOrDefault(a => a.StoreID == StorageId && a.ProductID == productId);
                    currentProduct.Qtu += Convert.ToDouble(item.Cells[2].Value);
                }

            }
            foreach (var item in productStores)
            {
                context.ProductStores.Add(item);
            }


            context.Orders.Add(order);
          if( context.SaveChanges() > 0)
            {
                MessageBox.Show("The Bill of is added","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

           
          
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProductStore> productStores = new List<ProductStore>();
            foreach (DataGridViewRow item in dataGridView1.Rows) {
                int productId =  Convert.ToInt32(item.Cells[0].Value);
                DateTime Exdate = Convert.ToDateTime(item.Cells[3].Value);
                DateTime Prdate = Convert.ToDateTime(item.Cells[4].Value);
                int StorageId = Convert.ToInt32(comboStorage.SelectedValue);
               var items = context.ProductStores.Where(a => a.ProductID == productId && DbFunctions.TruncateTime(a.ExpireDate) == Exdate.Date &&
               DbFunctions.TruncateTime(a.ProductDate) == Prdate.Date && a.StoreID == StorageId
               ).ToList();
                if(items.Count == 0)
                {
                    productStores.Add(new ProductStore()
                    {
                        ExpireDate = Convert.ToDateTime(item.Cells[3].Value),
                        ProductDate = Convert.ToDateTime(item.Cells[4].Value),
                        Qtu = Convert.ToInt32(item.Cells[2].Value),
                        ProductID = Convert.ToInt32(item.Cells[0].Value),
                        StoreID = Convert.ToInt32(comboStorage.SelectedValue)

                    });
                }
                else
                {

                    ProductStore currentProduct = context.ProductStores.FirstOrDefault(a => a.StoreID == StorageId && a.ProductID == productId);
                    currentProduct.Qtu += Convert.ToDouble(item.Cells[2].Value);
                }

            }
            foreach (var item in productStores)
            {
                context.ProductStores.Add(item);
            }
        }
    }
}
