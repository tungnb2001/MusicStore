using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    internal class OrderDetails
    {
        public int orderDetailId { get; set; }
        public int orderId { get; set; }
        public int albumId { get; set; }
        public int quantity { get; set; }
        public string unitPrice { get; set; }

        public OrderDetails()
        {
        }

        public OrderDetails(int orderDetailId, int orderId, int albumId, int quantity, string unitPrice)
        {
            this.orderDetailId = orderDetailId;
            this.orderId = orderId;
            this.albumId = albumId;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }
    }
}
