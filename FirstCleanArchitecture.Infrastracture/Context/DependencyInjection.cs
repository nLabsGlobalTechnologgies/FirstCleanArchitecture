using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FirstCleanArchitecture.Infrastracture.Context;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastracture(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("SqlServer");
        services.AddDbContext<AppDbContext>(sqlServerConfiguration =>
        {
            sqlServerConfiguration.UseSqlServer(connectionString);
        });
        return services;
    }
}
