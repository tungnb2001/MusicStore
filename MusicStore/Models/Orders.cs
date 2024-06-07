using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    internal class Orders
    {
        public int orderId { get; set; }
        public DateTime orderDate { get; set; } = DateTime.Now;
        public string promoCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string total { get; set; }

        public Orders()
        {
        }

        public Orders(int orderId, DateTime orderDate, string promoCode, string firstName, string lastName, string address, string city, string state, string country, string phone, string email, string total)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.promoCode = promoCode;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.country = country;
            this.phone = phone;
            this.email = email;
            this.total = total;
        }
    }
}
