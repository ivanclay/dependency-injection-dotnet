using DependencyStore.Repositories.Contracts;
using DependencyStore.Repositories;
using Microsoft.Data.SqlClient;
using DependencyStore.Services.Contracts;
using DependencyStore.Services;

namespace DependencyStore.Extensions;

public static class DependenciesExtensions
{
    public static void AddSqlConnection(this IServiceCollection services, string connection) 
    {
        services.AddScoped<SqlConnection>(x => new SqlConnection(connection));
    }

    public static void AddRepositories(this IServiceCollection services) 
    {
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<IPromoCodeRepository, PromoCodeRepository>();
    }

    public static void AddServices(this IServiceCollection services) 
    {
        services.AddTransient<IDeliveryFeeService, DeliveryFeeService>();
    }
}
