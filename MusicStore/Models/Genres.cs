using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    internal class Genres
    {
        public int genredId { get; set; }
        public string genreName { get; set; }
        public string description { get; set; }

        public Genres()
        {
        }

        public Genres(int genredId, string genreName, string description)
        {
            this.genredId = genredId;
            this.genreName = genreName;
            this.description = description;
        }
    }
}
