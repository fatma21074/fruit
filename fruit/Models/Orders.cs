using System.ComponentModel.DataAnnotations;

namespace fruit.Models
{
    public class Orders
    {
        [Key]
        public int ID { get; set; }
        public string status { get; set; }
        [Required]
        [MaxLength(100)]
        public string Customer_name { get; set; }
        public int date { get; set; }
        public string shippingaddress { get; set; }
        public string itemspurchased { get; set; }
        public int quantities { get; set; }
        public int total { get; set; }
    }
}
