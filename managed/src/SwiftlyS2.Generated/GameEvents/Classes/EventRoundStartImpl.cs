using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "round_start"
/// </summary>
internal class EventRoundStartImpl : GameEvent<EventRoundStart>, EventRoundStart
{

  public EventRoundStartImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // round time limit in seconds
  public int TimeLimit
  { get => GetInt("timelimit"); set => SetInt("timelimit", value); }

  // frag limit in seconds
  public int FragLimit
  { get => GetInt("fraglimit"); set => SetInt("fraglimit", value); }

  // round objective
  public string Objective
  { get => GetString("objective"); set => SetString("objective", value); }
}
