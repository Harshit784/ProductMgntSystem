using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class CustomerOrder
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey ("customerId")]
        public int customerId { get; set; }
        [ForeignKey ("productId")]
        public int productId { get; set; }

        public DateTime OrderedDate { get; set; }
    }
}
