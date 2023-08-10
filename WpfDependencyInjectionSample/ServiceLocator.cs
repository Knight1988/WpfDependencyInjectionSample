using Microsoft.Extensions.DependencyInjection;

namespace WpfDependencyInjectionSample;

public static class ServiceLocator
{
    public static ServiceProvider Current { get; set; }
}