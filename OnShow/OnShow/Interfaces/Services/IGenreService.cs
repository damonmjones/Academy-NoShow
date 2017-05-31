using OnShow.Models;
using System;
using System.Collections.Generic;

namespace OnShow.Interfaces.Services
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetGenres();
        Genre GetGenreById(Guid id);
    }
}
