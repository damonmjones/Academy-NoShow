using OnShow.Interfaces.ViewModels;
using OnShow.Models;
using System.Collections.Generic;

namespace OnShow.ViewModels
{
    public class GigFormViewModel : IGigViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}