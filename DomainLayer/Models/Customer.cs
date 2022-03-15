using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        [Key]
        public string customerName { get; set; }
        public int OrderId { get; set; }
    }
}
