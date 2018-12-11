using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        [Required]

        public Product Product
        {
            get; set;
        }

        public int Quantity
        {
            get; set;
        }

        public int ProductId
        {
            get; set;
        }
    }

   
}
