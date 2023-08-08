using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Models
{
	public class AppUsers :IdentityUser
	{
	  public string? SponsorId { get; set; }
	  public string RefCode { get; set; }
      public string? FullName { get; set; }
	  public string? StoreName { get; set; }
	  public string? StreetAddress { get; set; }
	  public string? StoreAddress { get; set; }
      public string? City { get; set;}
	  public string? State { get; set; }
	  public string? ZipCode { get; set;}
	  public decimal Balance { get; set; } = 0;
	  public int EarnedPoint { get; set; }= 0;
	  public string? ProfileImage { get; set; }
	}
}
