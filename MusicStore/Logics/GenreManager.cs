using MusicStore.DataAccess;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Logics
{
    internal class GenreManager
    {
        public static List<Genres> GetAllGenresFromDB()
        {
            return GenresDAO.GetAllGenre();
        }
    }
}
