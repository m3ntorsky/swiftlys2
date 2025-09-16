using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "finale_start"
/// </summary>
internal class EventFinaleStartImpl : GameEvent<EventFinaleStart>, EventFinaleStart
{

  public EventFinaleStartImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public short Rushes
  { get => (short)GetInt("rushes"); set => SetInt("rushes", value); }
}
