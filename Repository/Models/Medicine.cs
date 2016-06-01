using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Medicine : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProductForm { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public bool Recipe { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool Available { get; set; }
    }
}
