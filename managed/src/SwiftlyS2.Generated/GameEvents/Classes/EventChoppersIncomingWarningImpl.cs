using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "choppers_incoming_warning"
/// </summary>
internal class EventChoppersIncomingWarningImpl : GameEvent<EventChoppersIncomingWarning>, EventChoppersIncomingWarning
{

  public EventChoppersIncomingWarningImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public bool Global
  { get => GetBool("global"); set => SetBool("global", value); }
}
