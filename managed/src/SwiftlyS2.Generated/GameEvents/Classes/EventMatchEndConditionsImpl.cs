using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "match_end_conditions"
/// </summary>
internal class EventMatchEndConditionsImpl : TypedGameEvent<EventMatchEndConditions>, EventMatchEndConditions
{


  public int FragS
  { get => Accessor.GetInt32("frags"); set => Accessor.SetInt32("frags", value); }

  public int MaxRounds
  { get => Accessor.GetInt32("max_rounds"); set => Accessor.SetInt32("max_rounds", value); }

  public int WinRounds
  { get => Accessor.GetInt32("win_rounds"); set => Accessor.SetInt32("win_rounds", value); }

  public int Time
  { get => Accessor.GetInt32("time"); set => Accessor.SetInt32("time", value); }
}
