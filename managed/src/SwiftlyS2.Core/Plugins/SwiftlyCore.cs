using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Events;
using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Core.Misc;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Services;


internal class SwiftlyCore : ISwiftlyCore, IDisposable {

  private ServiceProvider _ServiceProvider { get; init; }

  public EventSubscriber EventSubscriber { get; init; }
  public GameEventService GameEventService { get; init; }
  public NetMessageService NetMessageService { get; init; }
  public PluginConfigurationService Configuration { get; init; }
  public ILoggerFactory LoggerFactory { get; init; }


  public SwiftlyCore(string contextId, string contextBaseDirectory, IServiceProvider coreProvider) {

    CoreContext id = new(contextId, contextBaseDirectory);

    ServiceCollection services = new();

    services
      .AddSingleton(id)
      .AddSingleton(this)
      .AddSingleton(coreProvider.GetRequiredService<ProfileService>())
      .AddSingleton(coreProvider.GetRequiredService<ConfigurationService>())

      .AddSingleton<EventSubscriber>()
      .AddSingleton<PluginConfigurationService>()
      .AddSingleton<GameEventService>()
      .AddSingleton<NetMessageService>()

      .AddLogging(
        builder => {
          builder.AddProvider(new SwiftlyLoggerProvider(id.Name));
        }
      );


    _ServiceProvider = services.BuildServiceProvider();

    EventSubscriber = _ServiceProvider.GetRequiredService<EventSubscriber>();
    Configuration = _ServiceProvider.GetRequiredService<PluginConfigurationService>();
    GameEventService = _ServiceProvider.GetRequiredService<GameEventService>();
    LoggerFactory = _ServiceProvider.GetRequiredService<ILoggerFactory>();
    NetMessageService = _ServiceProvider.GetRequiredService<NetMessageService>();
  }

  public void Dispose() {
    _ServiceProvider.Dispose();
  }

  IEventSubscriber ISwiftlyCore.Event => EventSubscriber;
  IPluginConfigurationService ISwiftlyCore.Configuration => Configuration;
  ILoggerFactory ISwiftlyCore.LoggerFactory => LoggerFactory;
  IGameEventService ISwiftlyCore.GameEvent => GameEventService;
  INetMessageService ISwiftlyCore.NetMessage => NetMessageService;

}