using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.Models
{
   public class ProductStore
    {
        public int ID { get; set; }
        [ForeignKey("Store")]
        public int StoreID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public double Qtu { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime ProductDate { get; set; }

        public Store Store { get; set; }

        public Product Product { get; set; }


    }
}
