using Microsoft.Extensions.DependencyInjection;
using SANA.Shop.Domain.Repositories;
using SANA.Shop.Persistence.Repositories;

namespace SANA.Shop.Persistence
{
    public static class DependencyInjection
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
        }
    }
}
