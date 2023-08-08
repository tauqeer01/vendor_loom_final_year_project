using System.ComponentModel.DataAnnotations;

namespace Bobmlm.Models
{
    public class LevelCount
    {
        [Key]
        public int SrId { get; set; }
        public int TotalFree { get; set; }
        public int TotalPaid { get; set; }
        public string Regno { get; set; }
       
    }
}
