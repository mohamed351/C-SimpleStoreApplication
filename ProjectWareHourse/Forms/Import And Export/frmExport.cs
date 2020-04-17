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

namespace ProjectWareHourse.Forms.Import_And_Export
{
    public partial class frmExport : Form
    {
        WareHourseContext context = new WareHourseContext();
        ICollection<ProductStore> Store;
        Product product;
        public frmExport()
        {
            InitializeComponent();

            comboCustomer.DataSource = context.People.Where(a => a.Type == TypeOfPerson.Customer && !a.IsDeleted).ToList();
            comboCustomer.DisplayMember = "Name";
            comboCustomer.ValueMember = "ID";

            
            comboStore.DataSource = context.Stores.ToList();
            comboStore.DisplayMember = "Name";
            comboStore.ValueMember = "ID";

            txtProductName.Enabled = false;
            txtNumricUpDown.Enabled = false;
            dataGridView1.Columns.Add("ProductID", "ProductID");
            dataGridView1.Columns.Add("ProductName", "ProductName");
            dataGridView1.Columns.Add("Qtu", "Qtu");
 
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
           
            if(e.KeyCode == Keys.Enter)
            {
              product  = context.Products.Include(async=>async.ProductStores).FirstOrDefault(a => a.Code == txtCode.Text);
                if(product == null)
                {
                    txtCode.Text = "";
                    txtProductName.Text = "";
                    txtNumricUpDown.Enabled = false;
                    MessageBox.Show("The Product Doesn't Exist ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {

                    Store = product.ProductStores;
                    txtProductName.Text = product.Name;
                   
                    maxQuantity.Text = GetMaxQuantity(product.ProductStores).ToString();
                    txtNumricUpDown.Maximum = Convert.ToDecimal(GetMaxQuantity(product.ProductStores));
                

                    txtNumricUpDown.Enabled = true;
                    txtNumricUpDown.Focus();




                }
            } 
        }
        private double GetMaxQuantity(ICollection<ProductStore> stores)
        {
            double total =0;
            foreach (var item in Store.Select(a => a.Qtu).ToList())
            {
                total += item; 
            }
            return total;
           
        }

        private void txtNumricUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (product == null)
                {
                    throw new Exception("Please Enter product code !!!");
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtNumricUpDown.Value > 0)
                    {
                        int index = GetIndex();

                        if (index == -1)
                        {
                            dataGridView1.Rows.Add(product.ID, product.Name, txtNumricUpDown.Value);
                        }
                        else
                        {
                            double qtu = Convert.ToDouble(dataGridView1.Rows[index].Cells[2].Value);
                            qtu += Convert.ToDouble(txtNumricUpDown.Value);
                            if (qtu < GetMaxQuantity(product.ProductStores))
                            {

                                dataGridView1.Rows[index].Cells[2].Value = qtu;
                            }
                            else
                            {
                                dataGridView1.Rows[index].Cells[2].Value = GetMaxQuantity(product.ProductStores);
                            }

                        }
                    }
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private int GetIndex()
        {
            int index = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) ==  this.product.ID)
                {
                    return i;
                }

            }
            return index;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Order order = new Order();
                order.OrderDetails = new List<OrderDetails>();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    int productID = Convert.ToInt32(item.Cells[0].Value);
                    if(productID != 0){
                        int storage = Convert.ToInt32(comboStore.SelectedValue);
                        Product product = context.Products.Include(async => async.ProductStores)
                            .FirstOrDefault(a => a.ID == productID);
                        SubTrackStore(product, Convert.ToDouble(item.Cells[2].Value),storage,order);
                    }

                }
                context.Entry(order).State = EntityState.Added;
                int x = context.SaveChanges();
                MessageBox.Show(x.ToString());
            }
            catch(Exception ex)
            {
                throw ex;


            }
        }

        private void SubTrackStore(Product product, double qtuop, int storageID ,Order order)
        {
            Stack<ProductStore> stores = new Stack<ProductStore>();
      
           
            order.PersonID = Convert.ToInt32(comboCustomer.SelectedValue);
            order.StorageName = comboStore.Text;
            order.TypeOf = TypeOfOrders.Export;
            order.DateOfOperation = DateTime.Now;
           
           

            var item = product.ProductStores.Where(a=>a.StoreID == storageID && a.Qtu !=0).OrderBy(a => a.ExpireDate).ToList();
           

            item.Sort((x, y) => DateTime.Compare(x.ExpireDate, y.ExpireDate));
            foreach (var i in item)
            {
                stores.Push(i);
            }
            double mainQtu = qtuop;
            while (stores.Count > 0)
            {

                ProductStore productStore = stores.Pop();
                if (productStore.Qtu == mainQtu)
                {
                    order.OrderDetails.Add(new OrderDetails()
                    {
                        ExpireDateProduct = productStore.ExpireDate.Date,
                        ProductionDate = productStore.ProductDate.Date,
                        ProductID = product.ID,
                        Qtu = mainQtu
                    });

                    productStore.Qtu = 0;
                   
                    break;
                }
                else if (productStore.Qtu > mainQtu)
                {
                    order.OrderDetails.Add(new OrderDetails()
                    {
                        ExpireDateProduct = productStore.ExpireDate.Date,
                        ProductionDate = productStore.ProductDate.Date,
                        ProductID = product.ID,
                        Qtu = mainQtu
                    });

                    double qtu = mainQtu;
                    productStore.Qtu -= qtu;

                    break;

                }
                else if (productStore.Qtu < mainQtu)
                {
                    order.OrderDetails.Add(new OrderDetails()
                    {
                        ExpireDateProduct = productStore.ExpireDate.Date,
                        ProductionDate = productStore.ProductDate.Date,
                        ProductID = product.ID,
                        Qtu = mainQtu
                    });
                    mainQtu -= productStore.Qtu;
                    productStore.Qtu = 0;



                }
             
           
                context.Entry(product).State = EntityState.Modified;

         
                




            }
        }
    }
}
