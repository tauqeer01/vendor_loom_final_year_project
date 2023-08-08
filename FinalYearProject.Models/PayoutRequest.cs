using FinalYearProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Models
{
	public class PayoutRequest
	{
		[Key]
		public int Id { get; set; }
		public string UserId { get; set; }
	    [ForeignKey(nameof(UserId))]
		public AppUsers AppUsers { get; set; }
		public decimal Amount { get; set; }
		public decimal? Fees { get; set; }
		public string PaymentMode { get; set; }
		public string ?UpiAddress { get; set; }
		public string? BankName { get; set; }
		public string? AccountNumber { get; set; }
		public string ?IfscCode { get; set; }
		public string? Code { get; set; }
		public string TransType { get; set; }
		public string trStatus { get; set; }
		public DateTime TransDate { get; set; }
	}
}
