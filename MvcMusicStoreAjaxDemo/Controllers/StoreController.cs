using Microsoft.AspNetCore.Mvc;
using MvcMusicStoreAjaxDemo.Models;
using MvcMusicStoreAjaxDemo.ViewModels;

namespace MvcMusicStoreAjaxDemo.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };

            var vm = new StoreIndexViewModel
            {
                NumberOfGenres = genres.Count,
                Genres = genres
            };

            ViewBag.Starred = new List<string> { "Rock", "Jazz" };
            return View(vm);
        }

        public IActionResult Browse(string genre)
        {
            var vm = new StoreBrowseViewModel
            {
                Genre = new Genre { Name = genre },
                Albums = new List<Album>
                {
                    new Album { Title = $"{genre} Album 1" },
                    new Album { Title = $"{genre} Album 2" }
                }
            };
            return View(vm);
        }

        public IActionResult Details(int id)
        {
            var album = new Album { Title = "Sample Album" };
            return View(album);
        }
    }
}
