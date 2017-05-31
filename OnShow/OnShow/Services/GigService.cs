using OnShow.Interfaces.Services;
using OnShow.Models;
using System;

namespace OnShow.Services
{
    public class GigService : IGigService
    {
        public void SaveChanges(Gig gig)
        {
            using (var db = new ApplicationDbContext())
            {
                try
                {
                    db.Gigs.Add(gig);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception($"Something went wrong saving to database, {e}");
                }
            }
        }
    }
}