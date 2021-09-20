using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RetailSoftware_API_Jatin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailSoftware_API_Jatin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryToCustomer> DeliveryToCustomers { get; set; }
    }
}
