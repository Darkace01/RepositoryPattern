using System.ComponentModel.DataAnnotations;

namespace ECommerceStoreWebApi.Core.Domain
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Item name is required")]
        public string ItemName { get; set; }
        [Required]
        public double ItemPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Description { get; set; }
    }
}