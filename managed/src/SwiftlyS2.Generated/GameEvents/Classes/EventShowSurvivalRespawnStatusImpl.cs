using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "show_survival_respawn_status"
/// </summary>
internal class EventShowSurvivalRespawnStatusImpl : TypedGameEvent<EventShowSurvivalRespawnStatus>, EventShowSurvivalRespawnStatus
{

  public EventShowSurvivalRespawnStatusImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public string LocToken
  { get => Accessor.GetString("loc_token"); set => Accessor.SetString("loc_token", value); }

  public int Duration
  { get => Accessor.GetInt32("duration"); set => Accessor.SetInt32("duration", value); }

  public CCSPlayerController UserId
  { get => Accessor.GetPlayerController("userid"); }
}
