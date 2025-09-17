using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "seasoncoin_levelup"
/// </summary>
public interface EventSeasoncoinLevelup : ITypedGameEvent<EventSeasoncoinLevelup> {

  static EventSeasoncoinLevelup ITypedGameEvent<EventSeasoncoinLevelup>.Wrap(IGameEvent accessor) => new EventSeasoncoinLevelupImpl(accessor);

  static string ITypedGameEvent<EventSeasoncoinLevelup>.GetName() => "seasoncoin_levelup";

  static uint ITypedGameEvent<EventSeasoncoinLevelup>.GetHash() => 0xF0EAD821u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short Category { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Rank { get; set; }

}
