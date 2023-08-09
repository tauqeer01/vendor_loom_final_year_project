
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalYearProject.Models
{
	public class OrderDetail
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int OrderHeaderId { get; set; }
		
		public OrderHeader OrderHeader { get; set; }
		[Required]
		public int ProductId { get; set; }
		
		public Product Product { get; set; }
		public int Count { get; set; }
		public decimal Price { get; set; }
	}
}
