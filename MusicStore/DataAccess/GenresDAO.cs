using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess
{
    internal class GenresDAO
    {
        public static List<Genres> GetAllGenre()
        {
            string sql = "select * from  Genres ";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Genres> list = new List<Genres>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new Genres(
                    Convert.ToInt32(dr["GenreId"]),
                    dr["Name"].ToString(),
                    dr["Description"].ToString()
                    ));
            return list;
        }
    }
}
