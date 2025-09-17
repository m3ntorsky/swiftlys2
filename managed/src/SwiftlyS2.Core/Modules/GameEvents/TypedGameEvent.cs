using SwiftlyS2.Shared.GameEvents;

namespace SwiftlyS2.Core.GameEvents;

internal abstract class TypedGameEvent<T> where T : ITypedGameEvent<T> {

  public IGameEvent Accessor { get; private init; }

  public TypedGameEvent(IGameEvent accessor) {
    Accessor = accessor;
  }

  public bool DontBroadcast { 
    get => Accessor.DontBroadcast;
    set => Accessor.DontBroadcast = value;
  }

  public void Fire() {
    Accessor.Fire();
  }

  public void FireToClient(int clientId) {
    Accessor.FireToClient(clientId);
  }



}