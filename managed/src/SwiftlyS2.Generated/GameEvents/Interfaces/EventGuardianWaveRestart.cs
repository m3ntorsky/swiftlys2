using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "guardian_wave_restart"
/// </summary>
public interface EventGuardianWaveRestart : ITypedGameEvent<EventGuardianWaveRestart> {

  static EventGuardianWaveRestart ITypedGameEvent<EventGuardianWaveRestart>.Wrap(IGameEvent accessor) => new EventGuardianWaveRestartImpl(accessor);

  static string ITypedGameEvent<EventGuardianWaveRestart>.GetName() => "guardian_wave_restart";

  static uint ITypedGameEvent<EventGuardianWaveRestart>.GetHash() => 0xA7FB81A6u;
}
