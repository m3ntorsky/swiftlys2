namespace SwiftlyS2.Shared.Events;

/// <summary>
/// Custom event subscriber interface.
/// </summary>
public interface IEventSubscriber {

  /// <summary>
  /// Called when game has processed a tick. Won't be called if the server is in hibernation.
  /// </summary>
  public event EventListeners.OnTick? OnTick;

}