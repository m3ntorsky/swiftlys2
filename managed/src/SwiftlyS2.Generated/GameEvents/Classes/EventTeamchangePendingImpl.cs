using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "teamchange_pending"
/// </summary>
internal class EventTeamchangePendingImpl : TypedGameEvent<EventTeamchangePending>, EventTeamchangePending
{

  public EventTeamchangePendingImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }

  public byte ToTeam
  { get => (byte)Accessor.GetInt32("toteam"); set => Accessor.SetInt32("toteam", value); }
}
