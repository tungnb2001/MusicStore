using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    internal class Carts
    {
        public int recordId { get; set; }
        public string cartId { get; set; }
        public int albumId { get; set; }
        public int count { get; set; }
        public DateTime dateCreated { get; set; }

        public Carts()
        {
        }

        public Carts(int recordId, string cartId, int albumId, int count, DateTime dateCreated)
        {
            this.recordId = recordId;
            this.cartId = cartId;
            this.albumId = albumId;
            this.count = count;
            this.dateCreated = dateCreated;
        }
    }
}
