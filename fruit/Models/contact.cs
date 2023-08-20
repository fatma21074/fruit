using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fruit.Models
{
    public class contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string message { get; set; }
        [ForeignKey("Accountsnum")]
        public int phonenum { get; set; }
        public Accounts accounts { get; set; }
    }
}
