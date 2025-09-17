using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "open_crate_instr"
/// </summary>
internal class EventOpenCrateInstrImpl : TypedGameEvent<EventOpenCrateInstr>, EventOpenCrateInstr
{


  // player entindex
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // crate entindex
  public short Subject
  { get => (short)Accessor.GetInt32("subject"); set => Accessor.SetInt32("subject", value); }

  // type of crate (metal, wood, or paradrop)
  public string Type
  { get => Accessor.GetString("type"); set => Accessor.SetString("type", value); }
}
