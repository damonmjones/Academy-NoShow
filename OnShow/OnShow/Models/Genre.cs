using OnShow.Interfaces.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnShow.Models
{
    public class Genre : IGenre
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}