using OnShow.Interfaces.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnShow.Models
{
    public class Gig : IGig
    {
        public Guid Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}