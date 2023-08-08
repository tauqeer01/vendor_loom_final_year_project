using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        [Range(1, 1000, ErrorMessage ="Please enter value between 1 and 1000")]
        public int Count { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUsers AppUsers { get; set; }
        [NotMapped]
        public decimal Price { get; set; }  

    }
}
