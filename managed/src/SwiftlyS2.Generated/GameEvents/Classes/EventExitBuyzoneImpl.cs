using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "exit_buyzone"
/// </summary>
internal class EventExitBuyzoneImpl : GameEvent<EventExitBuyzone>, EventExitBuyzone
{

  public EventExitBuyzoneImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  public bool CanBuy
  { get => GetBool("canbuy"); set => SetBool("canbuy", value); }
}
