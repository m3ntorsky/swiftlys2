using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_dropped"
/// </summary>
internal class EventBombDroppedImpl : GameEvent<EventBombDropped>, EventBombDropped
{

  public EventBombDroppedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who dropped the bomb
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public int EntIndex
  { get => GetInt("entindex"); set => SetInt("entindex", value); }
}
