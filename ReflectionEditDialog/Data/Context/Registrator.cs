using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReflectionEditDialog.Infrastructure.Services;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;

namespace ReflectionEditDialog.Data.Context
{
    internal static class Registrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration config) => services
           //.AddDbContext<EmployeesDB>(opt => opt.UseSqlServer(config.GetConnectionString("SQLServer")))
           .AddDbContextFactory<EmployeesDB>(opt => opt.UseSqlServer(config.GetConnectionString("SQLServer")))
           .AddScoped(typeof(IRepository<>), typeof(DbRepository<>))
        ;
    }
}
