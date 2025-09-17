using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "team_intro_end"
/// </summary>
public interface EventTeamIntroEnd : ITypedGameEvent<EventTeamIntroEnd> {

  static EventTeamIntroEnd ITypedGameEvent<EventTeamIntroEnd>.Create() => new EventTeamIntroEndImpl();

  static string ITypedGameEvent<EventTeamIntroEnd>.GetName() => "team_intro_end";

  static uint ITypedGameEvent<EventTeamIntroEnd>.GetHash() => 0x46EF839Bu;
}
