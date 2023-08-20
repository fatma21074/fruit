using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("CategoriesId")]
        public int CategoriesId { get; set; }
        public Categories categories { get; set; }
        [ForeignKey("Accountsnum")]
        public int phonenum { get; set; }
        public Accounts accounts { get; set; }
        [ForeignKey("InventoryId")]
        public int InventoryId { get; set; }
        public Inventory inventory { get; set; }
    }
}
