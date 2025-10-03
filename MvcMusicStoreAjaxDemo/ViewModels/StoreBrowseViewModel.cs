using System.Collections.Generic;
using MvcMusicStoreAjaxDemo.Models;

namespace MvcMusicStoreAjaxDemo.ViewModels
{
    public class StoreBrowseViewModel
    {
        public Genre Genre { get; set; } = new();
        public List<Album> Albums { get; set; } = new();
    }
}
