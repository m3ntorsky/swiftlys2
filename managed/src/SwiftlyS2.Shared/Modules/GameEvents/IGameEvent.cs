namespace SwiftlyS2.Shared.GameEvents;

public interface IGameEvent<T>  where T : IGameEvent<T> {

  public IGameEventAccessor Accessor { get; }

  internal static abstract T Create();
  internal static abstract string GetName();
  internal static abstract uint GetHash();

  /// <summary>
  /// When true, the event will not be broadcast to clients.
  /// </summary>
  public bool DontBroadcast { get; set; }

}