using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "difficulty_changed"
/// </summary>
internal class EventDifficultyChangedImpl : GameEvent<EventDifficultyChanged>, EventDifficultyChanged
{

  public EventDifficultyChangedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public short NewDifficulty
  { get => (short)GetInt("newDifficulty"); set => SetInt("newDifficulty", value); }

  public short OldDifficulty
  { get => (short)GetInt("oldDifficulty"); set => SetInt("oldDifficulty", value); }

  // new difficulty as string
  public string StrDifficulty
  { get => GetString("strDifficulty"); set => SetString("strDifficulty", value); }
}
