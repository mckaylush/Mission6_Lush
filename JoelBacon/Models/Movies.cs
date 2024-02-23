using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Lush.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int MovieId { get; set;}

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set;}
        public Categories? Category { get; set;}

        [Required(ErrorMessage = "Please enter the movie title")]
        public string Title { get; set;}

        [Required(ErrorMessage = "Please enter the year")]

        [Range(1888, int.MaxValue, ErrorMessage ="Movie has to be made between 1888 and 2025")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "Please enter if the movie was edited")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Please select whether it was copied or not to Plex")]
        public int CopiedToPlex { get; set; }

        [MaxLength(25, ErrorMessage = "Notes have to be 25 letters or less.")]
        public string? Notes { get; set; }

    }
}
