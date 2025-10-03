using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "demo_start"
/// </summary>
internal class EventDemoStartImpl : GameEvent<EventDemoStart>, EventDemoStart
{

  public EventDemoStartImpl(nint address) : base(address)
  {
  }
}
