using MusicStore.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Logics
{
    internal class ArtistsManager
    {
        public static string GetArtistByIdFromDB(int id)
        {
            return ArtistsDAO.GetArtistByID(id);
        }
    }
}
