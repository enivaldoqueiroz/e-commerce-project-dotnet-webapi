using EShop.Orders.Core.Entities;
using EShop.Orders.Core.ValueObjects;

namespace EShop.Orders.Core.Events
{
    internal class OrderCreated : IDomainEvent
    {
        public OrderCreated(Guid id, decimal totalPrice, PaymentInfo paymentInfo, string fullname, string email)
        {
            Id = id; 
            TotalPrice = totalPrice;
            PaymentInfo = paymentInfo;
            FullName = fullname;
            Email = email;
        }
        public Guid Id { get;}
        public decimal TotalPrice { get; }
        public PaymentInfo PaymentInfo { get; }
        public string FullName { get; }
        public string Email { get; }
    }
}