using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_rank_camera"
/// a camera ranking
/// </summary>
internal class EventHltvRankCameraImpl : GameEvent<EventHltvRankCamera>, EventHltvRankCamera
{

  public EventHltvRankCameraImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // fixed camera index
  public byte Index
  { get => (byte)GetInt("index"); set => SetInt("index", value); }

  // ranking, how interesting is this camera view
  public float Rank
  { get => GetFloat("rank"); set => SetFloat("rank", value); }

  // best/closest target entity
  public int Target
  { get => GetPlayerSlot("target"); set => SetPlayerSlot("target", value); }
}
