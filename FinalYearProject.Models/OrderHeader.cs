﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalYearProject.Models
{
	public class OrderHeader
	{
		[Key]
		public int Id { get; set; }
		public string UserId { get; set; }
		[ForeignKey(nameof(UserId))]
		public AppUsers AppUsers { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime ShippingDate { get; set; }
		public decimal OrderTotal { get; set; }
		public string? OrderStatus { get; set; }
		public string? PaymentStatus { get;set; }
		public string? TrackingNumber { get; set;}
		public string? Carrier { get; set; }
		public DateTime PaymentDate { get; set; }
		public string? PaymentIntentId { get; set; }

		[Required] 
		public string PhoneNumber { get; set; }
		[Required]
		public string StreetAddress { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string State { get; set; }
		[Required]
		public string PostalCode { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
