using System;

namespace RestaurantOrderManager.Models
{
    public class Order
    {
        public int orderId {  get;  set; }
        public string orderName { get; set; }
        public string status { get; set; }

        public Order()
        {
        }

    }
}