using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "team_intro_end"
/// </summary>
public interface EventTeamIntroEnd : IGameEvent<EventTeamIntroEnd> {

  static EventTeamIntroEnd IGameEvent<EventTeamIntroEnd>.FromAllocated(nint ptr) => new EventTeamIntroEndImpl(ptr, true);

  static EventTeamIntroEnd IGameEvent<EventTeamIntroEnd>.FromExternal(nint ptr) => new EventTeamIntroEndImpl(ptr, false);

  static string IGameEvent<EventTeamIntroEnd>.GetName() => "team_intro_end";

  static uint IGameEvent<EventTeamIntroEnd>.GetHash() => 0x46EF839Bu;
}
