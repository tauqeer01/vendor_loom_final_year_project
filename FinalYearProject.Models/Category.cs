using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		public  string CategoryName { get; set; }	
		public  string? ImageUrl { get; set; }
		public string UserId { get; set; }

		[ForeignKey(nameof(UserId))]
		public AppUsers AppUsers { get; set; }
		public DateTime CreateAt { get; set; }
	}
}
