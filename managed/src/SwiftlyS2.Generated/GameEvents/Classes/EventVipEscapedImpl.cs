using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vip_escaped"
/// </summary>
internal class EventVipEscapedImpl : GameEvent<EventVipEscaped>, EventVipEscaped
{

  public EventVipEscapedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // player who was the VIP
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
