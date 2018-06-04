using AbcMovies.Models;
using System.Collections.Generic;

namespace AbcMovies.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit View";
                return "New View";
            }
        }

    }
}