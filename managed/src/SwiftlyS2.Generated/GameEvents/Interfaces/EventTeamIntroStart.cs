using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "team_intro_start"
/// </summary>
public interface EventTeamIntroStart : IGameEvent<EventTeamIntroStart> {

  static EventTeamIntroStart IGameEvent<EventTeamIntroStart>.FromAllocated(nint ptr) => new EventTeamIntroStartImpl(ptr, true);

  static EventTeamIntroStart IGameEvent<EventTeamIntroStart>.FromExternal(nint ptr) => new EventTeamIntroStartImpl(ptr, false);

  static string IGameEvent<EventTeamIntroStart>.GetName() => "team_intro_start";

  static uint IGameEvent<EventTeamIntroStart>.GetHash() => 0xB7C4858Eu;
}
