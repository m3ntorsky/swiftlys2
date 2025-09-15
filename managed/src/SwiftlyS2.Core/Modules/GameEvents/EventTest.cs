namespace SwiftlyS2.Core.GameEvents;

internal class EventTest : GameEvent {

  public override string Name => "EventTest";

  internal override ulong Hash => 0;

  public EventTest(nint handle) : base(handle) {
  }
}
