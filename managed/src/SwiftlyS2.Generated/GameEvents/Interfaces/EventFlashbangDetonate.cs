using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "flashbang_detonate"
/// </summary>
public interface EventFlashbangDetonate : ITypedGameEvent<EventFlashbangDetonate> {

  static EventFlashbangDetonate ITypedGameEvent<EventFlashbangDetonate>.Wrap(IGameEvent accessor) => new EventFlashbangDetonateImpl(accessor);

  static string ITypedGameEvent<EventFlashbangDetonate>.GetName() => "flashbang_detonate";

  static uint ITypedGameEvent<EventFlashbangDetonate>.GetHash() => 0x575C9970u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float X { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Y { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Z { get; set; }

}
