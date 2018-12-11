using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class Products
    {
        public int ProductId
        { get; set; }
        [Required]
        [StringLength(50)]


        public string Name { get; set; }
        [Required]

        public decimal Price { get; set; }

        public int ProductCategoryId
        { get; set; }

        public ProductCategory ProductCategory
        { get; set; }
    }



    
}
