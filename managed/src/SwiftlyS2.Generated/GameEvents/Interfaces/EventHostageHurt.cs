using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hostage_hurt"
/// </summary>
public interface EventHostageHurt : ITypedGameEvent<EventHostageHurt> {

  static EventHostageHurt ITypedGameEvent<EventHostageHurt>.Create() => new EventHostageHurtImpl();

  static string ITypedGameEvent<EventHostageHurt>.GetName() => "hostage_hurt";

  static uint ITypedGameEvent<EventHostageHurt>.GetHash() => 0x5F292C42u;
  /// <summary>
  /// player who hurt the hostage
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// hostage entity index
  /// <br/>
  /// type: short
  /// </summary>
  short Hostage { get; set; }

}
