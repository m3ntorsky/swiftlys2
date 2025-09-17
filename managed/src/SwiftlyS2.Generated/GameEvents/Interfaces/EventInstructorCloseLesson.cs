using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "instructor_close_lesson"
/// </summary>
public interface EventInstructorCloseLesson : ITypedGameEvent<EventInstructorCloseLesson> {

  static EventInstructorCloseLesson ITypedGameEvent<EventInstructorCloseLesson>.Create() => new EventInstructorCloseLessonImpl();

  static string ITypedGameEvent<EventInstructorCloseLesson>.GetName() => "instructor_close_lesson";

  static uint ITypedGameEvent<EventInstructorCloseLesson>.GetHash() => 0x2C472152u;
  /// <summary>
  /// The player who this lesson is intended for
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// Name of the lesson to start.  Must match instructor_lesson.txt
  /// <br/>
  /// type: string
  /// </summary>
  string HintName { get; set; }

}
