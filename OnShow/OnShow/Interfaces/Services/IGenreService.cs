using OnShow.Models;
using System.Collections.Generic;

namespace OnShow.Interfaces.Services
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetGenres();
    }
}
