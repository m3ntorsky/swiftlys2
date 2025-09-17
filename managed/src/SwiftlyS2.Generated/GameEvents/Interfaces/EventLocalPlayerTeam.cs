using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "local_player_team"
/// </summary>
public interface EventLocalPlayerTeam : ITypedGameEvent<EventLocalPlayerTeam> {

  static EventLocalPlayerTeam ITypedGameEvent<EventLocalPlayerTeam>.Create() => new EventLocalPlayerTeamImpl();

  static string ITypedGameEvent<EventLocalPlayerTeam>.GetName() => "local_player_team";

  static uint ITypedGameEvent<EventLocalPlayerTeam>.GetHash() => 0x04FD6AB4u;
}
