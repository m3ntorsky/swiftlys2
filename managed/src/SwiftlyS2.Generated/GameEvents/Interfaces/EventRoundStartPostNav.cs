using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_start_post_nav"
/// </summary>
public interface EventRoundStartPostNav : IGameEvent<EventRoundStartPostNav> {

  static EventRoundStartPostNav IGameEvent<EventRoundStartPostNav>.FromAllocated(nint ptr) => new EventRoundStartPostNavImpl(ptr, true);

  static EventRoundStartPostNav IGameEvent<EventRoundStartPostNav>.FromExternal(nint ptr) => new EventRoundStartPostNavImpl(ptr, false);

  static string IGameEvent<EventRoundStartPostNav>.GetName() => "round_start_post_nav";

  static uint IGameEvent<EventRoundStartPostNav>.GetHash() => 0x0F2F9F25u;
}
