using ProjectWareHourse.Models;
using ProjectWareHourse.Validation;
using ProjectWareHourse.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWareHourse.Forms.Import_And_Export
{
    public partial class SelectedFrm : Form
    {
        WareHourseContext context = new WareHourseContext();
        DataStoreViewModel _dataStoreViewModel;
        int StoreID;
        public SelectedFrm(DataStoreViewModel dataStoreViewModel)
        {
            this._dataStoreViewModel = dataStoreViewModel;
          
            InitializeComponent();
            StoreCombo.DataSource = context.Stores.Where(a => a.ID != dataStoreViewModel.StoreID).ToList();
            StoreCombo.DisplayMember = "Name";
            StoreCombo.ValueMember = "ID";

            QtuNumber.Minimum = 1;
            QtuNumber.Maximum = Convert.ToDecimal(dataStoreViewModel.Qtu);
            txtMax.Text = $"Max Quantity {_dataStoreViewModel.Qtu}";
            ExpireDateCombo.Text = _dataStoreViewModel.ExpireDate.Date.ToString();
            ProductionCombo.Text = _dataStoreViewModel.ProductDate.Date.ToString();

           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WareHouseTransformationLogs logs = new WareHouseTransformationLogs();
            logs.DestinationStoreID = Convert.ToInt32(StoreCombo.SelectedValue);
            logs.DestinationStoreName = StoreCombo.Text;
            logs.SourceStoreID = _dataStoreViewModel.StoreID;
            logs.SourceStorageName = _dataStoreViewModel.SourceStorage;
            logs.ProductName = _dataStoreViewModel.Name;
            logs.Quantity = _dataStoreViewModel.Qtu;
            logs.ExpireDate = _dataStoreViewModel.ExpireDate;
            logs.ProductionDate = _dataStoreViewModel.ProductDate;
            logs.TransfromationDate = DateTime.Now;


        MyValidationContext con =   CustomValidation.IsValid<WareHouseTransformationLogs>(logs);

          if (con.IsValid)
            {

                double qtu = Convert.ToDouble(QtuNumber.Value);
                ProductStore store =  context.ProductStores.SingleOrDefault(a => a.ID == _dataStoreViewModel.ID);
                store.Qtu -= qtu;

                context.ProductStores.Add(new ProductStore()
                {
                        ExpireDate = _dataStoreViewModel.ExpireDate,
                        ProductDate = _dataStoreViewModel.ProductDate,
                        ProductID = _dataStoreViewModel.ProductID,
                       Qtu =qtu,
                       StoreID =  Convert.ToInt32(StoreCombo.SelectedValue),
                      
                       
                      

                });
                context.Logs.Add(logs);
               if(context.SaveChanges() > 0)
                {
                    MessageBox.Show("Successfull Move to Another Storage ","Store",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                

            }
          else
            {



                foreach (var item in con.results)
                {
                    MessageBox.Show(item.ErrorMessage);
                }

            }













        }
    }
}
