using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "round_prestart"
/// sent before all other round restart actions
/// </summary>
internal class EventRoundPrestartImpl : TypedGameEvent<EventRoundPrestart>, EventRoundPrestart
{

  public EventRoundPrestartImpl(IGameEvent accessor) : base(accessor)
  {
  }
}
