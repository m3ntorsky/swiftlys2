using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "demo_skip"
/// </summary>
internal class EventDemoSkipImpl : GameEvent<EventDemoSkip>, EventDemoSkip
{

  public EventDemoSkipImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // current playback tick
  public int PlaybackTick
  { get => GetInt("playback_tick"); set => SetInt("playback_tick", value); }

  // tick we're going to
  public int SkiptoTick
  { get => GetInt("skipto_tick"); set => SetInt("skipto_tick", value); }
}
