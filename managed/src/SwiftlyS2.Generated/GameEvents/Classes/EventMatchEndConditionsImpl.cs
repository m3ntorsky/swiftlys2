using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "match_end_conditions"
/// </summary>
internal class EventMatchEndConditionsImpl : GameEvent<EventMatchEndConditions>, EventMatchEndConditions
{

  public EventMatchEndConditionsImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int FragS
  { get => GetInt("frags"); set => SetInt("frags", value); }

  public int MaxRounds
  { get => GetInt("max_rounds"); set => SetInt("max_rounds", value); }

  public int WinRounds
  { get => GetInt("win_rounds"); set => SetInt("win_rounds", value); }

  public int Time
  { get => GetInt("time"); set => SetInt("time", value); }
}
