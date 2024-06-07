using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess
{
    internal class ArtistsDAO
    {
        public static string GetArtistByID (int id)
        {
            string sql = "select * from  Artists where ArtistId =" +id;
           
            DataTable dt = DAO.GetDataBySql(sql);
            DataRow dr = dt.Rows[0];
            Artists artist = new Artists(
                Convert.ToInt32(dr["ArtistId"]),
                dr["Name"].ToString());
            return artist.artistName;
        }
    }
}
