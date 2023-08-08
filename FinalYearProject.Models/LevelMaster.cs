using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobmlm.Models
{
	public class LevelMaster
	{
		[Key]
		public int Id { get; set; }
		public int Level { get; set; }
		public decimal? Points { get; set; }

	}
}
