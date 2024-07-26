using EShop.Orders.Core.Entities;

namespace EShop.Orders.Application.DTOs.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel(Guid id, decimal totalPrice, DateTime createdAt, string status)
        {
            Id = id;
            TotalPrice = totalPrice;
            CreatedAt = createdAt;
            Status = status;
        }

        public Guid Id { get; private set; }
        public decimal TotalPrice { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string Status { get; private set; }

        public static OrderViewModel FromEntity(Order order)
        {
            return new OrderViewModel(order.Id, order.TotalPrice, order.CreatedAt, order.Status.ToString());
        }
    }
}
