using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValoRank.Models
{
    public class Member
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string IGN { get; set; }
        public string Rank { get; set; }
        [DisplayName("Tag Number")]
        public int TagNo { get; set; }
    }
}
