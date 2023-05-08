using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RosePlus.AppServices.Repositories;
using RosePlus.DataAccess.Configurations;
using RosePlus.DataAccess.Configurations.Interfaces;
using RosePlus.DataAccess.Context;
using RosePlus.DataAccess.Context.Repositories;

namespace RosePlus.Registrar;

public static class RosePlusRegistrar
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddDbContext<RosePlusContext>((Action<IServiceProvider, DbContextOptionsBuilder>) 
            ((sp, dbOptions) => sp.GetRequiredService<IDbContextOptionsConfigurator<RosePlusContext>>()
                .Configure((DbContextOptionsBuilder<RosePlusContext>) dbOptions)));

        services.AddSingleton<IDbContextOptionsConfigurator<RosePlusContext>, RosePlusContextConfiguration>();

        services.AddScoped(sp => (DbContext) sp.GetRequiredService<RosePlusContext>());

        services.AddScoped( typeof(IRepository<>), typeof(Repository<>));
        
        return services;
    }
}