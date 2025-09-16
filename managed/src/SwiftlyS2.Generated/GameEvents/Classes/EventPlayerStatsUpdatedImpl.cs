using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_stats_updated"
/// </summary>
internal class EventPlayerStatsUpdatedImpl : GameEvent<EventPlayerStatsUpdated>, EventPlayerStatsUpdated
{

  public EventPlayerStatsUpdatedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public bool ForceUpload
  { get => GetBool("forceupload"); set => SetBool("forceupload", value); }
}
