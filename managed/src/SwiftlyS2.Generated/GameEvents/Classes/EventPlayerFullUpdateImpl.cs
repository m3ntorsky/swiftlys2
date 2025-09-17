using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_full_update"
/// </summary>
internal class EventPlayerFullUpdateImpl : TypedGameEvent<EventPlayerFullUpdate>, EventPlayerFullUpdate
{


  // user ID on server
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  // Number of this full update
  public short Count
  { get => (short)Accessor.GetInt32("count"); set => Accessor.SetInt32("count", value); }
}
