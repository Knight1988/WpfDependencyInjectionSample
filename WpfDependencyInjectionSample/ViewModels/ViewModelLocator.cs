using Microsoft.Extensions.DependencyInjection;

namespace WpfDependencyInjectionSample.ViewModels;

public class ViewModelLocator
{
    public static MainViewModel MainWindow => ServiceLocator.Current.GetService<MainViewModel>();
}