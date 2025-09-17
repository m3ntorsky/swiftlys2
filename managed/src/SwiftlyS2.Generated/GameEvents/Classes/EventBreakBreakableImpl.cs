using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "break_breakable"
/// </summary>
internal class EventBreakBreakableImpl : TypedGameEvent<EventBreakBreakable>, EventBreakBreakable
{


  public int EntIndex
  { get => Accessor.GetInt32("entindex"); set => Accessor.SetInt32("entindex", value); }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // BREAK_GLASS, BREAK_WOOD, etc
  public byte Material
  { get => (byte)Accessor.GetInt32("material"); set => Accessor.SetInt32("material", value); }
}
