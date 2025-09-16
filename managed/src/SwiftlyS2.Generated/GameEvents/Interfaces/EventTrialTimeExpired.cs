using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "trial_time_expired"
/// </summary>
public interface EventTrialTimeExpired : IGameEvent<EventTrialTimeExpired> {

  static EventTrialTimeExpired IGameEvent<EventTrialTimeExpired>.FromAllocated(nint ptr) => new EventTrialTimeExpiredImpl(ptr, true);

  static EventTrialTimeExpired IGameEvent<EventTrialTimeExpired>.FromExternal(nint ptr) => new EventTrialTimeExpiredImpl(ptr, false);

  static string IGameEvent<EventTrialTimeExpired>.GetName() => "trial_time_expired";

  static uint IGameEvent<EventTrialTimeExpired>.GetHash() => 0xA80BA2FFu;
  /// <summary>
  /// player whose time has expired
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
