using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_connect_full"
/// player has sent final message in the connection sequence
/// </summary>
internal class EventPlayerConnectFullImpl : TypedGameEvent<EventPlayerConnectFull>, EventPlayerConnectFull
{

  public EventPlayerConnectFullImpl(IGameEvent accessor) : base(accessor)
  {
  }

  // user ID on server (unique on server)
  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
