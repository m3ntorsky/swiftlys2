using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "round_freeze_end"
/// </summary>
internal class EventRoundFreezeEndImpl : TypedGameEvent<EventRoundFreezeEnd>, EventRoundFreezeEnd
{

  public EventRoundFreezeEndImpl(IGameEvent accessor) : base(accessor)
  {
  }
}
