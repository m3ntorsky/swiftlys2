using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "announce_phase_end"
/// </summary>
internal class EventAnnouncePhaseEndImpl : TypedGameEvent<EventAnnouncePhaseEnd>, EventAnnouncePhaseEnd
{

  public EventAnnouncePhaseEndImpl(IGameEvent accessor) : base(accessor)
  {
  }
}
