using System;
using System.ComponentModel.DataAnnotations;

namespace AbcMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Movie name is required")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime Releasedate { get; set; }

        [Display(Name = "Added Date")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Genre Type is Required")]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }


    }
}