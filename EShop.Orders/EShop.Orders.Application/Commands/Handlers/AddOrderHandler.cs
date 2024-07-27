using EShop.Orders.Core.Repositories;
using EShop.Orders.Infrastruture.MessageBus;
using MediatR;

namespace EShop.Orders.Application.Commands.Handlers
{
    public class AddOrderHandler : IRequestHandler<AddOrder, Guid>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMessageBusClient _messegeBusClient;

        public AddOrderHandler(IOrderRepository orderRepository, IMessageBusClient messegeBusClient)
        {
            _orderRepository = orderRepository;
            _messegeBusClient = messegeBusClient;
        }

        public async Task<Guid> Handle(AddOrder request, CancellationToken cancellationToken)
        {
            var order = request.ToEntity();

            await _orderRepository.AddAsync(order);

            foreach (var @event in order.Events) 
            {
                var routigKey = @event.GetType().Name.ToDashCase();
                _messegeBusClient.Publish(@event, routigKey, "order-service");
            }

            return order.Id;
        }
    }
}
