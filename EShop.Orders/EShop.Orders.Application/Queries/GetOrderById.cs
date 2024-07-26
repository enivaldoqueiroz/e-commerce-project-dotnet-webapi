using EShop.Orders.Application.DTOs.ViewModels;
using MediatR;

namespace EShop.Orders.Application.Queries
{
    public class GetOrderById : IRequest<OrderViewModel>
    {
        public GetOrderById(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
