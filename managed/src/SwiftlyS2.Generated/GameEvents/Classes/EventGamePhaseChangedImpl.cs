using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "game_phase_changed"
/// </summary>
internal class EventGamePhaseChangedImpl : TypedGameEvent<EventGamePhaseChanged>, EventGamePhaseChanged
{

  public EventGamePhaseChangedImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public short NewPhase
  { get => (short)Accessor.GetInt32("new_phase"); set => Accessor.SetInt32("new_phase", value); }
}
