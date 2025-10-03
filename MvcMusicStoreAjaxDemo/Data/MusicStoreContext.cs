using Microsoft.EntityFrameworkCore;
using MvcMusicStoreAjaxDemo.Models;

namespace MvcMusicStoreAjaxDemo.Data
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options) : base(options) { }

        public DbSet<Album> Albums { get; set; }
    }
}
