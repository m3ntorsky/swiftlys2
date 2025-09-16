using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_abortdefuse"
/// </summary>
internal class EventBombAbortdefuseImpl : GameEvent<EventBombAbortdefuse>, EventBombAbortdefuse
{

  public EventBombAbortdefuseImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who was defusing
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
