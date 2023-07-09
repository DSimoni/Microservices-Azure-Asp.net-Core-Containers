﻿namespace ECommerce.Api.Orders.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }

        public List<OrderItem> Items { get; set; }

    }
}
