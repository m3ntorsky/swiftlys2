using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "team_intro_start"
/// </summary>
public interface EventTeamIntroStart : ITypedGameEvent<EventTeamIntroStart> {

  static EventTeamIntroStart ITypedGameEvent<EventTeamIntroStart>.Wrap(IGameEvent accessor) => new EventTeamIntroStartImpl(accessor);

  static string ITypedGameEvent<EventTeamIntroStart>.GetName() => "team_intro_start";

  static uint ITypedGameEvent<EventTeamIntroStart>.GetHash() => 0xB7C4858Eu;
}
