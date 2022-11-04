using EntityRelationFKExample.Application.Services;
using EntityRelationFKExample.Domain.Interfaces.Repositories;
using EntityRelationFKExample.Domain.Interfaces.Services;
using EntityRelationFKExample.Infra.Data.Contexts;
using EntityRelationFKExample.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EntityRelationFKExample.IoC
{
    public static class IoCModule
    {
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProductContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MSSQL")));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
