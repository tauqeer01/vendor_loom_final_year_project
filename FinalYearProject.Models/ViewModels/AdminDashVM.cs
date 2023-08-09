using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Models.ViewModels
{
	public class AdminDashVM
	{
		public int TotalUser { get; set; }
		public int TotalVendors { get; set; }
		public decimal TotalSell { get; set; }
		public decimal PendingPayout { get; set; }
		public int PendingOrder { get; set; }
		public List<AppUsers> GetUser { get; set; }

	}	
}
