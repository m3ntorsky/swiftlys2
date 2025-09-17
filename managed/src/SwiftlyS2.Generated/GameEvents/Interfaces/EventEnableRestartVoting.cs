using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "enable_restart_voting"
/// </summary>
public interface EventEnableRestartVoting : ITypedGameEvent<EventEnableRestartVoting> {

  static EventEnableRestartVoting ITypedGameEvent<EventEnableRestartVoting>.Wrap(IGameEvent accessor) => new EventEnableRestartVotingImpl(accessor);

  static string ITypedGameEvent<EventEnableRestartVoting>.GetName() => "enable_restart_voting";

  static uint ITypedGameEvent<EventEnableRestartVoting>.GetHash() => 0x786801D0u;
  /// <summary>
  /// type: bool
  /// </summary>
  bool Enable { get; set; }

}
