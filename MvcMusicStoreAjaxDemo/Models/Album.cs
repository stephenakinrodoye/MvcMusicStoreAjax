using System.ComponentModel.DataAnnotations;

namespace MvcMusicStoreAjaxDemo.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        public string Title { get; set; } = "";

        [Required]
        public string Artist { get; set; } = "";
    }
}
