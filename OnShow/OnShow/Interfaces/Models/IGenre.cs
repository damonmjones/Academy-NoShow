using System;

namespace OnShow.Interfaces.Models
{
    public interface IGenre
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
