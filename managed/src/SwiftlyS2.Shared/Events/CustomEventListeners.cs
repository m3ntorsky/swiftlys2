namespace SwiftlyS2.Shared.Events;

/// <summary>
/// Custom event listeners.
/// </summary>
public class EventListeners {

  /// <summary>
  /// Called when game has processed a tick. Won't be called if the server is in hibernation.
  /// </summary>
  public delegate void OnTick();

}