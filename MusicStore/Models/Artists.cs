using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    internal class Artists
    {
        public int artistId { get; set; }
        public string artistName { get; set; }

        public Artists()
        {
        }

        public Artists(int artistId, string artistName)
        {
            this.artistId = artistId;
            this.artistName = artistName;
        }
    }
}
