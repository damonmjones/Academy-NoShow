using OnShow.Models;
using System;
using System.Collections.Generic;

namespace OnShow.Interfaces.ViewModels
{
    public interface IGigViewModel
    {
        string Venue { get; set; }
        string Date { get; set; }
        string Time { get; set; }
        Guid Genre { get; set; }
        IEnumerable<Genre> Genres { get; set; }
    }
}