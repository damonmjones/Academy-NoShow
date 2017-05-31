using OnShow.Models;
using System.Collections.Generic;

namespace OnShow.Interfaces.ViewModels
{
    public interface IGigViewModel
    {
        string Venue { get; set; }
        string Date { get; set; }
        string Time { get; set; }
        int Genre { get; set; }
        IEnumerable<Genre> Genres { get; set; }
    }
}