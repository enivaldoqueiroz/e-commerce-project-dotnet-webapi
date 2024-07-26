using EShop.Orders.Application.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace EShop.Orders.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(AddOrder).Assembly));

            return services;
        }
    }
}
