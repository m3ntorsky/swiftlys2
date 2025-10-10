using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Menus;

namespace SwiftlyS2.Core.Hosting;

internal static class MenuServiceInjection
{
    public static IServiceCollection AddMenuService(this IServiceCollection self)
    {
        self.AddSingleton<MenuService>();
        return self;
    }

    public static void UseMenuService(this IServiceProvider provider)
    {
        provider.GetRequiredService<MenuService>();
    }
}