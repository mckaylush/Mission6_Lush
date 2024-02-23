using System.ComponentModel.DataAnnotations;

namespace Mission06_Lush.Models
{
    public class Categories
    {
        [Key]
        [Required]

        public int CategoryId { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
