namespace ECommerce.Api.Orders.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public string UnitPrice { get; set; }

    }
}
