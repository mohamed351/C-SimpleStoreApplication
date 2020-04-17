using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.Models
{
    class WareHourseContext:DbContext
    {
        public WareHourseContext()
            :base("name=con")
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<ProductStore> ProductStores { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<WareHouseTransformationLogs> Logs { get; set; }
    }
}
