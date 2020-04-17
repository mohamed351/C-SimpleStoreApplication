using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWareHourse.Models
{
    class WareHouseTransformationLogs
    {
        public int ID { get; set; }
        [Required]
        public int DestinationStoreID { get; set; }
        [Required]
        public string DestinationStoreName { get; set; }
        [Required]
        public int SourceStoreID { get; set; }

        public string SourceStorageName { get; set; }
        [Required]
        public string  ProductName { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }

        [Required]
        public DateTime TransfromationDate { get; set; }
    }
}
