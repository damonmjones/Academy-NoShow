using System;
using OnShow.Models;

namespace OnShow.Interfaces.Models
{
    public interface IGig
    {
        Guid Id { get; set; }
        ApplicationUser Artist { get; set; }
        DateTime DateTime { get; set; }
        string Venue { get; set; }
        Genre Genre { get; set; }
    }
}