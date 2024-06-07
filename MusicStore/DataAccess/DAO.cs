using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string ConStr = config.GetConnectionString("MyConStr");
            return new SqlConnection(ConStr);
        }
        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, GetConnection());
                if (parameters != null || parameters.Length == 0)
                    command.Parameters.AddRange(parameters);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                return dt;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;

        }
        public static int ExecuteSql(string sql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, GetConnection());
                if (parameters != null) command.Parameters.AddRange(parameters);
                command.Connection.Open();
                int k = command.ExecuteNonQuery();
                command.Connection.Close();
                return k;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;

        }
}
}
