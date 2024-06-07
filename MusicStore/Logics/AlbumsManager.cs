using MusicStore.DataAccess;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Logics
{
    internal class AlbumsManager
    {
        public static List<Albums> GetAllAlbumsFromDB()
        {
            return AlbumsDAO.GetAllAlbums();

        }
        
    }
}
