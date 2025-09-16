using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "guardian_wave_restart"
/// </summary>
public interface EventGuardianWaveRestart : IGameEvent<EventGuardianWaveRestart> {

  static EventGuardianWaveRestart IGameEvent<EventGuardianWaveRestart>.FromAllocated(nint ptr) => new EventGuardianWaveRestartImpl(ptr, true);

  static EventGuardianWaveRestart IGameEvent<EventGuardianWaveRestart>.FromExternal(nint ptr) => new EventGuardianWaveRestartImpl(ptr, false);

  static string IGameEvent<EventGuardianWaveRestart>.GetName() => "guardian_wave_restart";

  static uint IGameEvent<EventGuardianWaveRestart>.GetHash() => 0xA7FB81A6u;
}
