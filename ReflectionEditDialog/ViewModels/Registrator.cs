using Microsoft.Extensions.DependencyInjection;

namespace ReflectionEditDialog.ViewModels
{
    internal static class Registrator
    {
        public static void AddViewModels(this IServiceCollection services) => services
           .AddSingleton<MainWindowViewModel>()
        ;
    }
}
