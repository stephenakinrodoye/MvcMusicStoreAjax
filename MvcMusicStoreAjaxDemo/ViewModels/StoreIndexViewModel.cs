
using System.Collections.Generic;

namespace MvcMusicStoreAjaxDemo.ViewModels
{
    public class StoreIndexViewModel
    {
        public int NumberOfGenres { get; set; }
        public List<string> Genres { get; set; } = new();
    }
}
