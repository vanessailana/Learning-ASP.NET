using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class Order


    {
        public int OrderId { get; set; }
        [Required]

        public DateTime Date { get; set; }

        public ICollection<OrderItem> OrderItems
        {
            get;set;
        }
    }
}
