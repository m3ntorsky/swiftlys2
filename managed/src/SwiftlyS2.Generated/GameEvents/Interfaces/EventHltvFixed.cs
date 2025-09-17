using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_fixed"
/// show from fixed view
/// </summary>
public interface EventHltvFixed : ITypedGameEvent<EventHltvFixed> {

  static EventHltvFixed ITypedGameEvent<EventHltvFixed>.Wrap(IGameEvent accessor) => new EventHltvFixedImpl(accessor);

  static string ITypedGameEvent<EventHltvFixed>.GetName() => "hltv_fixed";

  static uint ITypedGameEvent<EventHltvFixed>.GetHash() => 0xCA86FB76u;
  /// <summary>
  /// camera position in world
  /// <br/>
  /// type: long
  /// </summary>
  int PosX { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int Posy { get; set; }

  /// <summary>
  /// type: long
  /// </summary>
  int PosZ { get; set; }

  /// <summary>
  /// camera angles
  /// <br/>
  /// type: short
  /// </summary>
  short Theta { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Phi { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Offset { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float FOv { get; set; }

  /// <summary>
  /// follow this player
  /// <br/>
  /// type: player_controller
  /// </summary>
  int Target { get; set; }

}
