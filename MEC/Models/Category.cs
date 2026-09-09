using System.ComponentModel.DataAnnotations;

namespace MEC.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
        = new List<Product>();
    }
}
