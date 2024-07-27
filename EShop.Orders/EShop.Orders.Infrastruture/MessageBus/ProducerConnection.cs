using RabbitMQ.Client;

namespace EShop.Orders.Infrastruture.MessageBus
{
    public class ProducerConnection
    {
        public ProducerConnection(IConnection connection)
        {
            Connection = connection;
        }

        public IConnection  Connection { get; set; }
    }
}
