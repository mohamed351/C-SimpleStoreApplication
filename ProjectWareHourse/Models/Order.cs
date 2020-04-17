using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.Models
{
    public class Order
    {
        public int ID { get; set; }

        public int PersonID { get; set; }
        [ForeignKey("PersonID")]
        public Person Person { get; set; }
        public DateTime DateOfOperation { get; set; }
        public string StorageName { get; set; }
        public TypeOfOrders TypeOf { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }

    }
    public class OrderDetails
    {

        public int ID { get; set; }

        public int OrderID { get; set; }
        public int ProductID { get; set; }
    
        public double Qtu { get; set; }
        public DateTime? ExpireDateProduct { get; set; }
        public DateTime? ProductionDate { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }



    }
    
}
