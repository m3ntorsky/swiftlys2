using Microsoft.Extensions.Logging;
using SwiftlyS2.Shared.Convars;
using SwiftlyS2.Shared.EntitySystem;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.Modules.Commands;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Shared;

/// <summary>
/// Core interface of SwiftlyS2 framework.
/// </summary>
public interface ISwiftlyCore {


  /// <summary>
  /// Custom event subscriber.
  /// </summary>
  public IEventSubscriber Event { get; }

  /// <summary>
  /// Game event service.
  /// </summary>
  public IGameEventService GameEvent { get; }

  /// <summary>
  /// Net message service.
  /// </summary>
  public INetMessageService NetMessage { get; }

  /// <summary>
  /// Command service.
  /// </summary>
  public ICommandService Command { get; }

  /// <summary>
  /// Entity system service.
  /// </summary>
  public IEntitySystemService EntitySystem { get; }

  /// <summary>
  /// Convar service.
  /// </summary>
  public IConVarService ConVar { get; }

  /// <summary>
  /// Configuration service.
  /// </summary>
  public IPluginConfigurationService Configuration { get; }

  /// <summary>
  /// Game data service.
  /// </summary>
  public IGameDataService GameData { get; }

  /// <summary>
  /// Logger factory.
  /// </summary>
  public ILoggerFactory LoggerFactory { get; }

  /// <summary>
  /// Default logger.
  /// </summary>
  public ILogger Logger { get; }
}