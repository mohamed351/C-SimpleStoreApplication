using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.Models
{
   public class Person
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
       
        public string Fax { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Website { get; set; }
        public TypeOfPerson Type { get; set; }
        public bool  IsDeleted { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
