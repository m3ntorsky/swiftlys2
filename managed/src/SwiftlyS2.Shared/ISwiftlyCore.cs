using Microsoft.Extensions.Logging;
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Shared;

/// <summary>
/// Core interface of SwiftlyS2 framework.
/// </summary>
public interface ISwiftlyCore {


  /// <summary>
  /// Custom event subscriber.
  /// </summary>
  public IEventSubscriber Events { get; }



  /// <summary>
  /// Configuration service.
  /// </summary>
  public IPluginConfigurationService Configuration { get; }

  /// <summary>
  /// Logger factory.
  /// </summary>
  public ILoggerFactory LoggerFactory { get; }

}