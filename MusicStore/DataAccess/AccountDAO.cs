using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MusicStore.Models;

namespace MusicStore.DataAccess
{
    internal class AccountDAO
    {
        public static Users login(string username, string password)
        {

            string sql = "select * from Users where Username =@username and Password =@password";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@username", SqlDbType.NVarChar);
            parameters[0].Value = username;
            parameters[1] = new SqlParameter("@password", SqlDbType.NVarChar);
            parameters[1].Value = password;
            DataTable dt = DAO.GetDataBySql(sql, parameters);
            DataRow dr = dt.Rows[0];
            Users user = new Users(
                Convert.ToInt32(dr["id"]),
                dr["Username"].ToString(),
                dr["Password"].ToString(),
                dr["Firstname"].ToString(),
                dr["Lastname"].ToString(),
                dr["Address"].ToString(),
                dr["City"].ToString(),
                dr["State"].ToString(),
                dr["Country"].ToString(),
                dr["Phone"].ToString(),
                dr["Email"].ToString(),
                Convert.ToInt32(dr["role"])
                );
            return user;
        }

    }
}

       