using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "local_player_controller_team"
/// </summary>
public interface EventLocalPlayerControllerTeam : ITypedGameEvent<EventLocalPlayerControllerTeam> {

  static EventLocalPlayerControllerTeam ITypedGameEvent<EventLocalPlayerControllerTeam>.Create() => new EventLocalPlayerControllerTeamImpl();

  static string ITypedGameEvent<EventLocalPlayerControllerTeam>.GetName() => "local_player_controller_team";

  static uint ITypedGameEvent<EventLocalPlayerControllerTeam>.GetHash() => 0x06A77413u;
}
