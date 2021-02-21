using Microsoft.Extensions.DependencyInjection;
using ReflectionEditDialog.Data.Entityes;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal static class Registrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
           .AddScoped<IRepository<Employee>, EmployeesRepository>()
           .AddScoped<IRepository<Department>, DepartmentsRepository>()
           .AddScoped<IEmployeesManager, EmployeesManager>()
        ;
    }
}
