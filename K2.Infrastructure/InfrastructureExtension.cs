using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace K2.Infrastructure
{
    public static class InfrastructureExtension
    {
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services, IConfiguration configuration, string connectionName)
        {
            var connectionString = configuration.GetConnectionString(connectionName);

            return services
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connectionString)
                )
                .AddDatabaseDeveloperPageExceptionFilter()
            ;
        }
    }
}
