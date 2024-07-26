using EShop.Orders.Core.Enums;
using EShop.Orders.Core.Events;
using EShop.Orders.Core.ValueObjects;

namespace EShop.Orders.Core.Entities
{
    public class Order : AggregateRoot
    {
        public Order(Customer customer, DeliveryAddress deliveryAddress, PaymentAddress paymentAddress, PaymentInfo paymentInfo, List<OrderItem> items)
        {
            Id = Guid.NewGuid();
            TotalPrice = items.Sum( i => i.Quatity * i.Price);
            Customer = customer;
            DeliveryAddress = deliveryAddress;
            PaymentAddress = paymentAddress;
            PaymentInfo = paymentInfo;
            Items = items;

            CreatedAt = DateTime.Now;

            AddEvent(new OrderCreated(Id,
                                      TotalPrice,
                                      paymentInfo,
                                      Customer.FullName,
                                      Customer.Email));
        }

        public decimal TotalPrice { get; private set; }
        public Customer Customer { get; private set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public PaymentAddress PaymentAddress { get; private set; }
        public PaymentInfo PaymentInfo { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public OrderStatus Status { get; set; }

        public void SetAsCompleted()
        {
            Status = OrderStatus.Completed;
        }

        public void SetAsRejected()
        {
            Status = OrderStatus.Rejected;
        }
    }
}
