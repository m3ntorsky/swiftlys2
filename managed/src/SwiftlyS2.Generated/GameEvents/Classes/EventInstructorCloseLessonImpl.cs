using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "instructor_close_lesson"
/// </summary>
internal class EventInstructorCloseLessonImpl : GameEvent<EventInstructorCloseLesson>, EventInstructorCloseLesson
{

  public EventInstructorCloseLessonImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // The player who this lesson is intended for
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // Name of the lesson to start.  Must match instructor_lesson.txt
  public string HintName
  { get => GetString("hint_name"); set => SetString("hint_name", value); }
}
