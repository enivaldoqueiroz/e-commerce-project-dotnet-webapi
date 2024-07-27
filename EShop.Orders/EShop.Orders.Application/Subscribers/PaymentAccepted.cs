namespace EShop.Orders.Application.Subscribers
{
    public class PaymentAccepted
    {
        public Guid Id { get; set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
    }
}