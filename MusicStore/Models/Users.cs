using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    internal class Users
    {
        public int id { get; set; }
        public string userName { get; set; }    
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }    
        public string state { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int role {get; set; }

        public Users()
        {
        }

        public Users(int id, string userName, string password, string firstName, string lastName, string address, string city, string state, string country, string phone, string email, int role)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.country = country;
            this.phone = phone;
            this.email = email;
            this.role = role;
        }
    }
}
