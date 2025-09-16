using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_full_update"
/// </summary>
internal class EventPlayerFullUpdateImpl : GameEvent<EventPlayerFullUpdate>, EventPlayerFullUpdate
{

  public EventPlayerFullUpdateImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // user ID on server
  public CCSPlayerController UserId
  { get => GetPlayerController("userid"); }

  // Number of this full update
  public short Count
  { get => (short)GetInt("count"); set => SetInt("count", value); }
}
