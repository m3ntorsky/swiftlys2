using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_given_c4"
/// </summary>
internal class EventPlayerGivenC4Impl : GameEvent<EventPlayerGivenC4>, EventPlayerGivenC4
{

  public EventPlayerGivenC4Impl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // user ID who received the c4
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }
}
