using MusicStore.DataAccess;
using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Logics
{
    internal class AccountManager
    {
        public static Users LoginUserFromDB(string username , string password)
        {
            return AccountDAO.login(username , password);
        }
       
    }
}
