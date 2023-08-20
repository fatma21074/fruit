using System.ComponentModel.DataAnnotations;

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
    }
}
