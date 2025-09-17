namespace SwiftlyS2.Shared.GameEvents;

public interface ITypedGameEvent<T>  where T : ITypedGameEvent<T> {

  public IGameEvent Accessor { get; }

  internal static abstract T Wrap(IGameEvent accessor);
  internal static abstract string GetName();
  internal static abstract uint GetHash();

  /// <summary>
  /// When true, the event will not be broadcast to clients.
  /// </summary>
  public bool DontBroadcast { get; set; }

  /// <summary>
  /// Fires the event.
  /// </summary>
  public void Fire();

  /// <summary>
  /// Fires the event to a specific client.
  /// </summary>
  /// <param name="clientId">Target client slot/id.</param>
  public void FireToClient(int clientId);

}