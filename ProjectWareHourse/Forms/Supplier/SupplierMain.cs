using ProjectWareHourse.Helpers;
using ProjectWareHourse.Models;
using ProjectWareHourse.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWareHourse.Forms.Supplier
{
    public partial class SupplierMain : MetroFramework.Forms.MetroForm
    {
        WareHourseContext context = new WareHourseContext();
        Person selectedPerson = new Person();
        public SupplierMain()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            GetSupplier();
        }
        public void GetSupplier()
        {
            dataGridView1.DataSource = context.People.Where(a => a.Type == TypeOfPerson.Supplier && !a.IsDeleted).ToList();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["IsDeleted"].Visible = false;
            dataGridView1.Columns["Orders"].Visible = false;
            dataGridView1.Columns["Type"].Visible = false;
        }
         
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = txtName.Text,
                Phone = txtphone.Text,
                Fax = txtFax.Text,
                Website = txtwebsite.Text,
                Type = TypeOfPerson.Supplier

            };

            MyValidationContext vContext = CustomValidation.IsValid<Person>(person);

            if (vContext.IsValid)
            {
                context.People.Add(person);
                if (context.SaveChanges() > 0)
                {

                    MessageBox.Show("successfull Add Supplier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetSupplier();
                    ControlHelpers.EmptyGroupBox(this.groupForm);
                }

            }
            else
            {
                foreach (var item in vContext.results)
                {
                    MessageBox.Show(item.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {

                Person person = context.People.FirstOrDefault(a => a.ID == selectedPerson.ID);
                person.Name = txtName.Text;
                person.Fax = txtFax.Text;
                person.Phone = txtphone.Text;
                person.Website = txtwebsite.Text;

                MyValidationContext vContext = CustomValidation.IsValid<Person>(person);
                if (vContext.IsValid)
                {


                    context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    if (context.SaveChanges() > 0)
                    {

                        MessageBox.Show("successfull Edit Supplier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetSupplier();
                        ControlHelpers.EmptyGroupBox(this.groupForm);
                    }

                }
                else
                {
                    foreach (var item in vContext.results)
                    {
                        MessageBox.Show(item.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Invalid Operation");
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Person person = context.People.FirstOrDefault(a => a.ID == selectedPerson.ID);

            if (person != null)
            {
                person.IsDeleted = true;
                context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("successfull Delete Supplier", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetSupplier();
                    ControlHelpers.EmptyGroupBox(this.groupForm);
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {

                    selectedPerson.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    selectedPerson.Name = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                    selectedPerson.Phone = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
                    selectedPerson.Fax = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                    selectedPerson.Website = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
                    txtName.Text = selectedPerson.Name;
                    txtphone.Text = selectedPerson.Phone;
                    txtwebsite.Text = selectedPerson.Website;
                    txtFax.Text = selectedPerson.Fax;

                }
                else
                {
                    selectedPerson = new Person();
                }
            }
            catch
            {
                selectedPerson = new Person();
            }
        }
    }
}
