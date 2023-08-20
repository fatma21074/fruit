using System.ComponentModel.DataAnnotations;

namespace fruit.Models
{
    public class Accounts
    {
        [Key]
        public int phonenum { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string email { get; set; }
        public int password { get; set; }
        public string adderss { get; set; }
    }
}
