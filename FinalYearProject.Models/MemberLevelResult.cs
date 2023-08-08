using System.ComponentModel.DataAnnotations;

namespace Bobmlm.Models
{
    public class MemberLevelResult
    {
        [Key]
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
        public string SponsorUserName { get; set; }
        public int Level { get; set; }
    }
}
