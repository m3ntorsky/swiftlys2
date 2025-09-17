using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_start_post_nav"
/// </summary>
public interface EventRoundStartPostNav : ITypedGameEvent<EventRoundStartPostNav> {

  static EventRoundStartPostNav ITypedGameEvent<EventRoundStartPostNav>.Wrap(IGameEvent accessor) => new EventRoundStartPostNavImpl(accessor);

  static string ITypedGameEvent<EventRoundStartPostNav>.GetName() => "round_start_post_nav";

  static uint ITypedGameEvent<EventRoundStartPostNav>.GetHash() => 0x0F2F9F25u;
}
