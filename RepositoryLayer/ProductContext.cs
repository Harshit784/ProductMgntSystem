using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        

        DbSet<Customer> Customers { get; set; }
        DbSet<ProductService> Products { get; set; }
        DbSet<CustomerOrder> customerOrders { get; set; }

    }
}
