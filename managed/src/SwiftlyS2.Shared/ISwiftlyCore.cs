using SwiftlyS2.Shared.Events;

namespace SwiftlyS2.Shared;

/// <summary>
/// Core interface of SwiftlyS2 framework.
/// </summary>
public interface ISwiftlyCore {


  /// <summary>
  /// Custom event subscriber.
  /// </summary>
  public IEventSubscriber CustomEvents { get; }


}