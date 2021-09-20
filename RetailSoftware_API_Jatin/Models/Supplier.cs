using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailSoftware_API_Jatin.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public List<DeliveryToCustomer> DeliveryToCustomers { get; set; }

    }
}
