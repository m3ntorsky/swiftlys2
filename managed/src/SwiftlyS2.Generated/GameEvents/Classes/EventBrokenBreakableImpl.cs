using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "broken_breakable"
/// </summary>
internal class EventBrokenBreakableImpl : GameEvent<EventBrokenBreakable>, EventBrokenBreakable
{

  public EventBrokenBreakableImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int EntIndex
  { get => GetInt("entindex"); set => SetInt("entindex", value); }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // BREAK_GLASS, BREAK_WOOD, etc
  public byte Material
  { get => (byte)GetInt("material"); set => SetInt("material", value); }
}
