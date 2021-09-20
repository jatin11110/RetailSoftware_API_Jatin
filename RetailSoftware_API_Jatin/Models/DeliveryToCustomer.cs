using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailSoftware_API_Jatin.Models
{
    public class DeliveryToCustomer
    {
        public int ID { get; set; }
        public int SupplierID { get; set; }
        public int CustomerID { get; set; }
        public Supplier Supplier { get; set; }
        public Customer Customer { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<DateTime> DeliveryDate { get; set; }
        public decimal Price { get; set; }
    }
}
