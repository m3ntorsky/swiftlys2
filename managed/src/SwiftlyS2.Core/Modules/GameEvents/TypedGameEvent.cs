using SwiftlyS2.Shared.GameEvents;

namespace SwiftlyS2.Core.GameEvents;

internal class TypedGameEvent<T> where T : ITypedGameEvent<T> {

  public IGameEvent Accessor { get; private init; }

  public TypedGameEvent() {
    Accessor = new GameEvent();
  }

  public bool DontBroadcast { 
    get => Accessor.DontBroadcast;
    set => Accessor.DontBroadcast = value;
  }

}