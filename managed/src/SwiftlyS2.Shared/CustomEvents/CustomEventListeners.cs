namespace SwiftlyS2.Shared.CustomEvents;

/// <summary>
/// Custom event listeners.
/// </summary>
public class CustomEventListeners {

  /// <summary>
  /// Called when game has processed a tick. Won't be called if the server is in hibernation.
  /// </summary>
  public delegate void OnTick();

}