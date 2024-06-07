using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    internal class Albums
    {
        public int albumId { get; set; }
        public int genreId { get; set; }
        public int artistId { get; set; }
        public string title { get; set; }
        public  string price { get; set; }
        public string albumUrl { get; set; }

        public Albums()
        {
        }


        public Albums(int albumId, int genreId, int artistId, string title, string price, string albumUrl)
        {
            this.albumId = albumId;
            this.genreId = genreId;
            this.artistId = artistId;
            this.title = title;
            this.price = price;
            this.albumUrl = albumUrl;
        }
    }
}
