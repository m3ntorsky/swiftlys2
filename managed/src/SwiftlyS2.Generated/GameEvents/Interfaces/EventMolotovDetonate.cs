using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "molotov_detonate"
/// </summary>
public interface EventMolotovDetonate : ITypedGameEvent<EventMolotovDetonate> {

  static EventMolotovDetonate ITypedGameEvent<EventMolotovDetonate>.Wrap(IGameEvent accessor) => new EventMolotovDetonateImpl(accessor);

  static string ITypedGameEvent<EventMolotovDetonate>.GetName() => "molotov_detonate";

  static uint ITypedGameEvent<EventMolotovDetonate>.GetHash() => 0xD541EE9Au;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

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
