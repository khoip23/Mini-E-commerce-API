using System.ComponentModel.DataAnnotations;

namespace MEC.Models
{
    public class Category
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
