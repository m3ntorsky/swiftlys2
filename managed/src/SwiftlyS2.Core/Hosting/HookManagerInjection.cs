using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Hooks;
using SwiftlyS2.Core.Managers;
using SwiftlyS2.Core.Services;

namespace SwiftlyS2.Core.Hosting;

internal static class HookServiceInjection
{
	public static void AddHooking(this IServiceCollection self)
	{
		self.AddSingleton<HookManager>();
	}
} 