using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "open_crate_instr"
/// </summary>
public interface EventOpenCrateInstr : ITypedGameEvent<EventOpenCrateInstr> {

  static EventOpenCrateInstr ITypedGameEvent<EventOpenCrateInstr>.Create() => new EventOpenCrateInstrImpl();

  static string ITypedGameEvent<EventOpenCrateInstr>.GetName() => "open_crate_instr";

  static uint ITypedGameEvent<EventOpenCrateInstr>.GetHash() => 0x76409C38u;
  /// <summary>
  /// player entindex
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// crate entindex
  /// <br/>
  /// type: short
  /// </summary>
  short Subject { get; set; }

  /// <summary>
  /// type of crate (metal, wood, or paradrop)
  /// <br/>
  /// type: string
  /// </summary>
  string Type { get; set; }

}
