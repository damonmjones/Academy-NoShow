using OnShow.Interfaces.Services;
using OnShow.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnShow.Services
{
    public class GenreService : IGenreService
    {
        public IEnumerable<Genre> GetGenres()
        {
            using (var db = new ApplicationDbContext())
            {
                var genres = db.Genres.ToList();

                return genres;
            }
        }

        public Genre GetGenreById(Guid id)
        {
            using (var db = new ApplicationDbContext())
            {
                var genre = db.Genres.SingleOrDefault(g => g.Id == id);

                return genre;
            }
        }
    }
}