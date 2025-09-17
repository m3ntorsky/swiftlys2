using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "clientside_lesson_closed"
/// </summary>
internal class EventClientsideLessonClosedImpl : TypedGameEvent<EventClientsideLessonClosed>, EventClientsideLessonClosed
{


  public string LessonName
  { get => Accessor.GetString("lesson_name"); set => Accessor.SetString("lesson_name", value); }
}
