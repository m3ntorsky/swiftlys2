using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "gameinstructor_draw"
/// </summary>
public interface EventGameinstructorDraw : IGameEvent<EventGameinstructorDraw> {

  static EventGameinstructorDraw IGameEvent<EventGameinstructorDraw>.FromAllocated(nint ptr) => new EventGameinstructorDrawImpl(ptr, true);

  static EventGameinstructorDraw IGameEvent<EventGameinstructorDraw>.FromExternal(nint ptr) => new EventGameinstructorDrawImpl(ptr, false);

  static string IGameEvent<EventGameinstructorDraw>.GetName() => "gameinstructor_draw";

  static uint IGameEvent<EventGameinstructorDraw>.GetHash() => 0x6E89B5D7u;
}
