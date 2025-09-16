using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "set_instructor_group_enabled"
/// </summary>
internal class EventSetInstructorGroupEnabledImpl : GameEvent<EventSetInstructorGroupEnabled>, EventSetInstructorGroupEnabled
{

  public EventSetInstructorGroupEnabledImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string Group
  { get => GetString("group"); set => SetString("group", value); }

  public short Enabled
  { get => (short)GetInt("enabled"); set => SetInt("enabled", value); }
}
