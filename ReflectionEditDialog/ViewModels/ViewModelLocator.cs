using Microsoft.Extensions.DependencyInjection;

namespace ReflectionEditDialog.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainModel => App.Services.GetRequiredService<MainWindowViewModel>();
    }
}
