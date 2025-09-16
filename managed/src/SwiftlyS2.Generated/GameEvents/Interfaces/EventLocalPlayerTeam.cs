using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "local_player_team"
/// </summary>
public interface EventLocalPlayerTeam : IGameEvent<EventLocalPlayerTeam> {

  static EventLocalPlayerTeam IGameEvent<EventLocalPlayerTeam>.FromAllocated(nint ptr) => new EventLocalPlayerTeamImpl(ptr, true);

  static EventLocalPlayerTeam IGameEvent<EventLocalPlayerTeam>.FromExternal(nint ptr) => new EventLocalPlayerTeamImpl(ptr, false);

  static string IGameEvent<EventLocalPlayerTeam>.GetName() => "local_player_team";

  static uint IGameEvent<EventLocalPlayerTeam>.GetHash() => 0x04FD6AB4u;
}
