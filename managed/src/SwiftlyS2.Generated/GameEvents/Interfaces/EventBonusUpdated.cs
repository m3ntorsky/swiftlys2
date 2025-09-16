using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bonus_updated"
/// </summary>
public interface EventBonusUpdated : IGameEvent<EventBonusUpdated> {

  static EventBonusUpdated IGameEvent<EventBonusUpdated>.FromAllocated(nint ptr) => new EventBonusUpdatedImpl(ptr, true);

  static EventBonusUpdated IGameEvent<EventBonusUpdated>.FromExternal(nint ptr) => new EventBonusUpdatedImpl(ptr, false);

  static string IGameEvent<EventBonusUpdated>.GetName() => "bonus_updated";

  static uint IGameEvent<EventBonusUpdated>.GetHash() => 0x80BE746Cu;
  /// <summary>
  /// type: short
  /// </summary>
  short NumAdvanced { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short NumBronze { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short NumSilver { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short NumGold { get; set; }

}
