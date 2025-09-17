namespace SwiftlyS2.Shared.GameEvents;

public interface ITypedGameEvent<T>  where T : ITypedGameEvent<T> {

  public IGameEvent Accessor { get; }

  internal static abstract T Create();
  internal static abstract string GetName();
  internal static abstract uint GetHash();

  /// <summary>
  /// When true, the event will not be broadcast to clients.
  /// </summary>
  public bool DontBroadcast { get; set; }

}