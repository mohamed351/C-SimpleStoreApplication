using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.Models
{
   public class Product
    {
   
       
        public int ID { get; set; }
        public string Name { get; set; }
        public string MeasruingUnit { get; set; }
        [Index(IsUnique = true)]
        [StringLength(200)]
        [Required]
        public string Code { get; set; }
        public ICollection<ProductStore> ProductStores { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
