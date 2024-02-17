using System.ComponentModel.DataAnnotations;

namespace Mission06_Lush.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        public string Category {  get; set; }
        
        [Required(ErrorMessage = "Please enter the movie title")]
        public string Title { get; set;}

        [Range(1888, 2025, ErrorMessage ="Movie has to be made between 1888 and 2025")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the Director")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please select a choice")]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Notes have to be 25 letters or less.")]
        public string? Notes { get; set; }

    }
}
