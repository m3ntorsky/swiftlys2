namespace SwiftlyS2.Shared.CustomEvents;

/// <summary>
/// Custom event subscriber interface.
/// </summary>
public interface ICustomEventSubscriber {

  /// <summary>
  /// Called when game has processed a tick. Won't be called if the server is in hibernation.
  /// </summary>
  public event CustomEventListeners.OnTick? OnTick;

}