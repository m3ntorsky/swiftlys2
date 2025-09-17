using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "teamplay_round_start"
/// round restart
/// </summary>
public interface EventTeamplayRoundStart : ITypedGameEvent<EventTeamplayRoundStart> {

  static EventTeamplayRoundStart ITypedGameEvent<EventTeamplayRoundStart>.Wrap(IGameEvent accessor) => new EventTeamplayRoundStartImpl(accessor);

  static string ITypedGameEvent<EventTeamplayRoundStart>.GetName() => "teamplay_round_start";

  static uint ITypedGameEvent<EventTeamplayRoundStart>.GetHash() => 0xB3DC0DA2u;
  /// <summary>
  /// is this a full reset of the map
  /// <br/>
  /// type: bool
  /// </summary>
  bool FullReset { get; set; }

}
