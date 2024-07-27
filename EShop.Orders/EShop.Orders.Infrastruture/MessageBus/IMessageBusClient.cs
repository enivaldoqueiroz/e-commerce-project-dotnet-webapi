namespace EShop.Orders.Infrastruture.MessageBus
{
    public interface IMessageBusClient
    {
        void Publish(object messsage, string routingKey, string exchange);
    }
}
