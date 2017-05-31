using OnShow.Models;
using System;

namespace OnShow.Interfaces.Models
{
    public interface IGig
    {
        Guid Id { get; set; }
        ApplicationUser Artist { get; set; }
        string ArtistId { get; set; }
        DateTime DateTime { get; set; }
        string Venue { get; set; }
        Genre Genre { get; set; }
        Guid GenreId { get; set; }
    }
}