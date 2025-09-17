using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "clientside_lesson_closed"
/// </summary>
public interface EventClientsideLessonClosed : ITypedGameEvent<EventClientsideLessonClosed> {

  static EventClientsideLessonClosed ITypedGameEvent<EventClientsideLessonClosed>.Wrap(IGameEvent accessor) => new EventClientsideLessonClosedImpl(accessor);

  static string ITypedGameEvent<EventClientsideLessonClosed>.GetName() => "clientside_lesson_closed";

  static uint ITypedGameEvent<EventClientsideLessonClosed>.GetHash() => 0x251ECF23u;
  /// <summary>
  /// type: string
  /// </summary>
  string LessonName { get; set; }

}
