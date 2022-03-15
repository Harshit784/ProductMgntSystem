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
        public ProductContext(DbContextOptions options) : base(options) { }
        DbSet<ProductService> Products { get; set; }
    }
}
