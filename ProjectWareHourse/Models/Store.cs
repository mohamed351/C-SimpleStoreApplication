using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.Models
{
   public class Store
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<ProductStore> ProductStores { get; set; }
    }
}
