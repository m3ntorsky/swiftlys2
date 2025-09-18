using SwiftlyS2.Shared.GameEvents;

namespace SwiftlyS2.Core.GameEvents;

internal class GameEvent<T> where T : IGameEvent<T> {

  public IGameEventAccessor Accessor { get; private init; }

  public GameEvent() {
    Accessor = new GameEventAccessor();
  }

  public bool DontBroadcast { 
    get => Accessor.DontBroadcast;
    set => Accessor.DontBroadcast = value;
  }

}