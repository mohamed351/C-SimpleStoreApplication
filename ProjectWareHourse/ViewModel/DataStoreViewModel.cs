using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.ViewModel
{
  public  class DataStoreViewModel
    {
        //a.ID, a.Product.Name, a.ProductDate, a.ExpireDate, a.Qtu 
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SourceStorage { get; set; }
        [Required]
        public DateTime ProductDate { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        [Required]
        public int StoreID { get; set; }
     
        public int ProductID { get; set; }



        [Required]
        public double Qtu { get; set; }

    }
}
