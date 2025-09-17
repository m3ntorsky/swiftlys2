using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "gameinstructor_draw"
/// </summary>
public interface EventGameinstructorDraw : ITypedGameEvent<EventGameinstructorDraw> {

  static EventGameinstructorDraw ITypedGameEvent<EventGameinstructorDraw>.Wrap(IGameEvent accessor) => new EventGameinstructorDrawImpl(accessor);

  static string ITypedGameEvent<EventGameinstructorDraw>.GetName() => "gameinstructor_draw";

  static uint ITypedGameEvent<EventGameinstructorDraw>.GetHash() => 0x6E89B5D7u;
}
