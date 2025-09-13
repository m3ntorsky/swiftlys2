using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Events;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Plugins;


internal class SwiftlyCore : ISwiftlyCore, IDisposable {

  public EventSubscriber CustomEventSubscriber { get; init; }

  public PluginConfigurationService Configuration { get; init; }


  public SwiftlyCore(string pluginId, string pluginBaseDirectory, IServiceProvider coreProvider) {

    PluginId id = new(pluginId, pluginBaseDirectory);

    ServiceCollection services = new();

    services.AddSingleton<PluginId>(id);
    services.AddSingleton(coreProvider.GetRequiredService<ProfileService>());
    services.AddSingleton(coreProvider.GetRequiredService<ConfigurationService>());
    services.AddSingleton<EventSubscriber>();
    services.AddSingleton<PluginConfigurationService>();

    var provider = services.BuildServiceProvider();
    CustomEventSubscriber = provider.GetRequiredService<EventSubscriber>();
    Configuration = provider.GetRequiredService<PluginConfigurationService>();
  }

  public void Dispose() {
    CustomEventSubscriber.Dispose();
  }

  IEventSubscriber ISwiftlyCore.CustomEvents => CustomEventSubscriber;
  IPluginConfigurationService ISwiftlyCore.Configuration => Configuration;

}