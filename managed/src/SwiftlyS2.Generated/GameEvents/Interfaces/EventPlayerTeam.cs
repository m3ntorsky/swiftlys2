using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_team"
/// </summary>
public interface EventPlayerTeam : ITypedGameEvent<EventPlayerTeam> {

  static EventPlayerTeam ITypedGameEvent<EventPlayerTeam>.Wrap(IGameEvent accessor) => new EventPlayerTeamImpl(accessor);

  static string ITypedGameEvent<EventPlayerTeam>.GetName() => "player_team";

  static uint ITypedGameEvent<EventPlayerTeam>.GetHash() => 0xD57549C4u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// team id
  /// <br/>
  /// type: byte
  /// </summary>
  byte Team { get; set; }

  /// <summary>
  /// old team id
  /// <br/>
  /// type: byte
  /// </summary>
  byte OldTeam { get; set; }

  /// <summary>
  /// team change because player disconnects
  /// <br/>
  /// type: bool
  /// </summary>
  bool Disconnect { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Silent { get; set; }

  /// <summary>
  /// type: string
  /// </summary>
  string Name { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool IsBot { get; set; }

}
