using Microsoft.AspNet.Identity;
using OnShow.Interfaces.Services;
using OnShow.Models;
using OnShow.Services;
using OnShow.ViewModels;
using System;
using System.Web.Mvc;

namespace OnShow.Controllers
{
    public class GigsController : Controller
    {
        private readonly IGenreService _genreService;
        private readonly IGigService _gigService;

        public GigsController()
        {
            _gigService = new GigService();
            _genreService = new GenreService();
        }

        [Authorize]
        public ActionResult Create()
        {
            var vm = new GigFormViewModel
            {
                Genres = _genreService.GetGenres()
            };

            return View(vm);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel vm)
        {
            var gig = new Gig
            {
                Id = Guid.NewGuid(),
                ArtistId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse($"{vm.Date} {vm.Time}"),
                GenreId = vm.Genre,
                Venue = vm.Venue
            };

            _gigService.SaveChanges(gig);

            return RedirectToAction("Index", "Home");
        }
    }
}