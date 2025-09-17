using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "trial_time_expired"
/// </summary>
public interface EventTrialTimeExpired : ITypedGameEvent<EventTrialTimeExpired> {

  static EventTrialTimeExpired ITypedGameEvent<EventTrialTimeExpired>.Create() => new EventTrialTimeExpiredImpl();

  static string ITypedGameEvent<EventTrialTimeExpired>.GetName() => "trial_time_expired";

  static uint ITypedGameEvent<EventTrialTimeExpired>.GetHash() => 0xA80BA2FFu;
  /// <summary>
  /// player whose time has expired
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserId { get; }

}
