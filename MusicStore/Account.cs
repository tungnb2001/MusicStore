using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    public class Account
    {
        public static string UserName = "";
        public static int Role = 0;
        public static int page = 0;

        public static void nextPag()
        {
            page++;
        }
        public static int Pagging()
        {

            return page;
        }
    }
}
