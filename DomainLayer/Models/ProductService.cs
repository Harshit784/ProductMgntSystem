using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductService
    {
        public string productName { get; set; }
        public int productId { get; set; }
        [Key]
        public string productCategory { get; set; }
        public int OrderId { get; set; }

    }
}
