using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalYearProject.Models
{
    public class OfferBanner
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;

        [ForeignKey(nameof(UserId))]
        public AppUsers AppUsers { get; set; }
    }
}
