using SwiftlyS2.Core.Natives;

namespace SwiftlyS2.Core.GameEvents;

interface IGameEvent {
}

internal abstract class GameEvent : AllocableNativeHandle, IGameEvent {

  public abstract string Name { get; }
  internal abstract ulong Hash { get; }

  private bool IsFired { get; set; } = true;

  internal GameEvent(nint handle) : base(handle, false) {
  }

  public GameEvent() : base(0, true) {
    var handle = 0; // handle = NativeGameEvent.Create(Name)
    SetHandle(handle);
  }

  public void Fire()
  {
    if (IsFired) return;
    IsFired = true;
  }

  protected override bool Free() {
    if (IsFired) return true;
    // nativeGameEvent.Free
    
    return true;

  }
}
