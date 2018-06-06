using System;
using System.ComponentModel.DataAnnotations;

namespace AbcMovies.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public DateTime Releasedate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        public int NumberInStock { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}