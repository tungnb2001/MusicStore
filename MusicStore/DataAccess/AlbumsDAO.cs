using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess
{
    internal class AlbumsDAO
    {

        public static List<Albums> GetAllAlbums()
        {
            try
            {
                string sql = "select * from  Albums";
                DataTable dt = DAO.GetDataBySql(sql);
                List<Albums> list = new List<Albums>();
                foreach (DataRow dr in dt.Rows)
                {

                   Albums albums = (new Albums(
                       Convert.ToInt32(dr["AlbumId"]),
                       Convert.ToInt32(dr["GenreId"]),
                       Convert.ToInt32(dr["ArtistId"]),
                       dr["Title"].ToString(),
                       dr["Price"].ToString(),
                       dr["AlbumUrl"].ToString()
                       ));
                    list.Add(albums); 
                }

                return list;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;


        }
       
        
    }
}
