using System.ComponentModel.DataAnnotations;

namespace fruit.Models
{
    public class Product
    {
        [Key]
        public int idproduct { get; set; }
        public string type { get; set; }
        public string origin { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }
        public int stocklevel { get; set; }
        public string image { get; set; }
    }
}
