using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RosePlus.AppServices.Repositories;
using RosePlus.AppServices.Services.Attribute;
using RosePlus.AppServices.Services.AttributeValue;
using RosePlus.AppServices.Services.Category;
using RosePlus.AppServices.Services.Product;
using RosePlus.DataAccess.Configurations;
using RosePlus.DataAccess.Configurations.Interfaces;
using RosePlus.DataAccess.Context;
using RosePlus.DataAccess.Context.Repositories;
using RosePlus.Migrations;

namespace RosePlus.Registrar;

public static class RosePlusRegistrar
{
    public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
    {
        ConfigurationManager configuration = builder.Configuration;
        builder.Services
            .AddDataAccessServices()
            .AddAppServices();
        return builder;
    }
    private static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddDbContext<RosePlusContext>(
            (Action<IServiceProvider, DbContextOptionsBuilder>) 
            ((sp, dbOptions) => sp.GetRequiredService<IDbContextOptionsConfigurator<RosePlusContext>>()
                .Configure((DbContextOptionsBuilder<RosePlusContext>) dbOptions)));

        services.AddSingleton<IDbContextOptionsConfigurator<RosePlusContext>, RosePlusContextConfiguration>();

        services.AddScoped(sp => (DbContext) sp.GetRequiredService<RosePlusContext>());

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>))
            .AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<ILoggerDbRepository, LoggerRepository>()
            .AddScoped<ICategoryRepository, CategoryRepository>()
            .AddScoped<IAttributeRepository, AttributeRepository>()
            .AddScoped<IAttributeValueRepository, AttributeValueRepository>();
        
        return services;
    }
    
    private static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>()
            .AddScoped<ICategoryService, CategoryService>()
            .AddScoped<IAttributeService, AttributeService>()
            .AddScoped<IAttributeValueService, AttributeValueService>();
        
        return services;
    }
}