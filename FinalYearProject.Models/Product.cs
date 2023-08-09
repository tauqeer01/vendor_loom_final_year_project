using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string? ProductDescription { get; set; }
		public decimal ProductMRP { get; set; }
		public decimal FinalPrice { get; set; }
		public DateTime CreateAt { get; set; }= DateTime.Now;
		public DateTime UpdatedAt { get; set; }=DateTime.Now;
		public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }  // navigation property

    }
}
