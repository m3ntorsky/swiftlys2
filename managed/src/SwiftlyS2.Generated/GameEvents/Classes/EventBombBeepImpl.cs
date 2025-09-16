using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_beep"
/// </summary>
internal class EventBombBeepImpl : GameEvent<EventBombBeep>, EventBombBeep
{

  public EventBombBeepImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // c4 entity
  public int EntIndex
  { get => GetInt("entindex"); set => SetInt("entindex", value); }
}
