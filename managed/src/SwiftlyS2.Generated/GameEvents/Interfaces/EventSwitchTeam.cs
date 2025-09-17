using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "switch_team"
/// </summary>
public interface EventSwitchTeam : ITypedGameEvent<EventSwitchTeam> {

  static EventSwitchTeam ITypedGameEvent<EventSwitchTeam>.Wrap(IGameEvent accessor) => new EventSwitchTeamImpl(accessor);

  static string ITypedGameEvent<EventSwitchTeam>.GetName() => "switch_team";

  static uint ITypedGameEvent<EventSwitchTeam>.GetHash() => 0x53717ECBu;
  /// <summary>
  /// number of active players on both T and CT
  /// <br/>
  /// type: short
  /// </summary>
  short NumPlayers { get; set; }

  /// <summary>
  /// number of spectators
  /// <br/>
  /// type: short
  /// </summary>
  short NumSpectators { get; set; }

  /// <summary>
  /// average rank of human players
  /// <br/>
  /// type: short
  /// </summary>
  short AvgRank { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short NumTSlotsFree { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short NumCTSlotsFree { get; set; }

}
