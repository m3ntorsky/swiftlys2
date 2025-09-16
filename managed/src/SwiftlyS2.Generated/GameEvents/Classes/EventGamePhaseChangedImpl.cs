using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "game_phase_changed"
/// </summary>
internal class EventGamePhaseChangedImpl : GameEvent<EventGamePhaseChanged>, EventGamePhaseChanged
{

  public EventGamePhaseChangedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public short NewPhase
  { get => (short)GetInt("new_phase"); set => SetInt("new_phase", value); }
}
