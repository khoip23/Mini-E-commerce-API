using System.ComponentModel.DataAnnotations;

namespace MEC.Models
{
    public class Product
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int stockQuantity { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
