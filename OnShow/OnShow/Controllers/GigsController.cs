using OnShow.Interfaces.Services;
using OnShow.Services;
using OnShow.ViewModels;
using System.Web.Mvc;

namespace OnShow.Controllers
{
    public class GigsController : Controller
    {
        private readonly IGenreService _genreService;

        public GigsController()
        {
            _genreService = new GenreService();
        }

        public ActionResult Create()
        {
            var vm = new GigFormViewModel
            {
                Genres = _genreService.GetGenres()
            };

            return View(vm);
        }
    }
}