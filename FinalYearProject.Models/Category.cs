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
		public  string? CategoryImage { get; set; }
		public string VendorId { get; set; }

		[ForeignKey(nameof(VendorId))]
		public AppUsers AppUsers { get; set; }
		public DateTime CreateAt { get; set; }
	}
}
