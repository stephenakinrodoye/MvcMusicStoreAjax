using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMusicStoreAjaxDemo.Data;
using MvcMusicStoreAjaxDemo.Models;
using System.Net;

namespace MvcMusicStoreAjaxDemo.Controllers
{
    public class AlbumController : Controller
    {
        private readonly MusicStoreContext _context;
        public AlbumController(MusicStoreContext context) => _context = context;

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> CreateAlbum([FromBody] Album album)
        {
            if (!ModelState.IsValid) return Json(new { Message = "INVALID" });
            _context.Albums.Add(album);
            await _context.SaveChangesAsync();
            return Json(new { Message = "SUCCESS" });
        }

        [HttpPost]
        public async Task<IActionResult> GetAlbums()
        {
            var albums = await _context.Albums.ToListAsync();
            return Json(albums);
        }

        public string Browse(string genre)
        {
            // HTML-encode to avoid script injection
            var safe = WebUtility.HtmlEncode(genre);
            return $"Album.Browse, Genre = {safe}";
        }

        // GET: /Album/Details/5
        public string Details(int id)
        {
            return $"Album.Details, ID = {id}";
        }
    }
}
