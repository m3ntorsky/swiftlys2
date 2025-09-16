using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "clientside_lesson_closed"
/// </summary>
internal class EventClientsideLessonClosedImpl : GameEvent<EventClientsideLessonClosed>, EventClientsideLessonClosed
{

  public EventClientsideLessonClosedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public string LessonName
  { get => GetString("lesson_name"); set => SetString("lesson_name", value); }
}
