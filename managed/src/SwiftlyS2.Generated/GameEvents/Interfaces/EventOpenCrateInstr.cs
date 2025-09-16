using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "open_crate_instr"
/// </summary>
public interface EventOpenCrateInstr : IGameEvent<EventOpenCrateInstr> {

  static EventOpenCrateInstr IGameEvent<EventOpenCrateInstr>.FromAllocated(nint ptr) => new EventOpenCrateInstrImpl(ptr, true);

  static EventOpenCrateInstr IGameEvent<EventOpenCrateInstr>.FromExternal(nint ptr) => new EventOpenCrateInstrImpl(ptr, false);

  static string IGameEvent<EventOpenCrateInstr>.GetName() => "open_crate_instr";

  static uint IGameEvent<EventOpenCrateInstr>.GetHash() => 0x76409C38u;
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
