using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "firstbombs_incoming_warning"
/// </summary>
internal class EventFirstbombsIncomingWarningImpl : GameEvent<EventFirstbombsIncomingWarning>, EventFirstbombsIncomingWarning
{

  public EventFirstbombsIncomingWarningImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public bool Global
  { get => GetBool("global"); set => SetBool("global", value); }
}
