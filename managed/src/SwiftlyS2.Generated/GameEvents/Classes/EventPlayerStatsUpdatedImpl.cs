using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_stats_updated"
/// </summary>
internal class EventPlayerStatsUpdatedImpl : TypedGameEvent<EventPlayerStatsUpdated>, EventPlayerStatsUpdated
{

  public EventPlayerStatsUpdatedImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public bool ForceUpload
  { get => Accessor.GetBool("forceupload"); set => Accessor.SetBool("forceupload", value); }
}
