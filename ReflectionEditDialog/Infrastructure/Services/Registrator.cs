using Microsoft.Extensions.DependencyInjection;
using ReflectionEditDialog.Infrastructure.Services.Interfaces;

namespace ReflectionEditDialog.Infrastructure.Services
{
    internal static class Registrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
           .AddTransient<IUserDialog, AppWindowUserDialogService>();
    }
}
