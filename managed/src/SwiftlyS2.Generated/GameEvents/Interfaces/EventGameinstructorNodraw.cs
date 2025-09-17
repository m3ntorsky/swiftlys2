using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "gameinstructor_nodraw"
/// </summary>
public interface EventGameinstructorNodraw : ITypedGameEvent<EventGameinstructorNodraw> {

  static EventGameinstructorNodraw ITypedGameEvent<EventGameinstructorNodraw>.Create() => new EventGameinstructorNodrawImpl();

  static string ITypedGameEvent<EventGameinstructorNodraw>.GetName() => "gameinstructor_nodraw";

  static uint ITypedGameEvent<EventGameinstructorNodraw>.GetHash() => 0x067F31A8u;
}
