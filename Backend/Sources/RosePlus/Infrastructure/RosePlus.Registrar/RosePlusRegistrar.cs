using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RosePlus.AppServices.Repositories;
using RosePlus.AppServices.Services.Category;
using RosePlus.AppServices.Services.Product;
using RosePlus.DataAccess.Configurations;
using RosePlus.DataAccess.Configurations.Interfaces;
using RosePlus.DataAccess.Context;
using RosePlus.DataAccess.Context.Repositories;

namespace RosePlus.Registrar;

public static class RosePlusRegistrar
{
    public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
    {
        ConfigurationManager configuration = builder.Configuration;
        builder.Services
            .AddDataAccessServices()
            .AddAppServices(configuration);
        return builder;
    }
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddDbContext<RosePlusContext>(
            (Action<IServiceProvider, DbContextOptionsBuilder>) 
            ((sp, dbOptions) => sp.GetRequiredService<IDbContextOptionsConfigurator<RosePlusContext>>()
                .Configure((DbContextOptionsBuilder<RosePlusContext>) dbOptions)));

        services.AddSingleton<IDbContextOptionsConfigurator<RosePlusContext>, RosePlusContextConfiguration>();

        services.AddScoped(sp => (DbContext) sp.GetRequiredService<RosePlusContext>());

        services.AddScoped( typeof(IRepository<>), typeof(Repository<>))
            .AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<ILoggerDbRepository, LoggerRepository>()
            .AddScoped<ICategoryRepository, CategoryRepository>();
        
        return services;
    }
    
    public static IServiceCollection AddAppServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
        
        return services;
    }
}