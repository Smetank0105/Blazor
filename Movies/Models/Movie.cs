using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required, StringLength(100, MinimumLength = 3) ]
        public string Title { get; set; }
        [Range(typeof(DateOnly), "1888-10-14", "9999-12-31")]
        public DateOnly ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        public string? URL { get; set; }
        public string? ImageURL { get; set; }
    }
}
