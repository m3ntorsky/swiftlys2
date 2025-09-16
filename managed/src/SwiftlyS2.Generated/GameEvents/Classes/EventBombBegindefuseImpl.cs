using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_begindefuse"
/// </summary>
internal class EventBombBegindefuseImpl : GameEvent<EventBombBegindefuse>, EventBombBegindefuse
{

  public EventBombBegindefuseImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who is defusing
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public bool HasKit
  { get => GetBool("haskit"); set => SetBool("haskit", value); }
}
