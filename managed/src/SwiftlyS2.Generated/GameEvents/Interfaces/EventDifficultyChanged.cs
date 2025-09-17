using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "difficulty_changed"
/// </summary>
public interface EventDifficultyChanged : ITypedGameEvent<EventDifficultyChanged> {

  static EventDifficultyChanged ITypedGameEvent<EventDifficultyChanged>.Create() => new EventDifficultyChangedImpl();

  static string ITypedGameEvent<EventDifficultyChanged>.GetName() => "difficulty_changed";

  static uint ITypedGameEvent<EventDifficultyChanged>.GetHash() => 0xB261D803u;
  /// <summary>
  /// type: short
  /// </summary>
  short NewDifficulty { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short OldDifficulty { get; set; }

  /// <summary>
  /// new difficulty as string
  /// <br/>
  /// type: string
  /// </summary>
  string StrDifficulty { get; set; }

}
