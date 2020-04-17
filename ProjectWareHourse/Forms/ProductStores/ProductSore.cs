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

namespace ProjectWareHourse.Forms.ProductStores
{
    public partial class ProductSore : Form
    {
        WareHourseContext context = new WareHourseContext();
        public ProductSore()
        {
            InitializeComponent();
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
            stringCollection.AddRange(context.Products.Select(a => a.Name).ToArray());
            textBox1.AutoCompleteCustomSource = stringCollection;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.KeyDown += TextBox1_KeyDown;
          

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                dataGridView2.DataSource = context.Products.Where(a => a.Name == textBox1.Text); 
            }
        }
    }
}
