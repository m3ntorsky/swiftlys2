using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "announce_phase_end"
/// </summary>
public interface EventAnnouncePhaseEnd : ITypedGameEvent<EventAnnouncePhaseEnd> {

  static EventAnnouncePhaseEnd ITypedGameEvent<EventAnnouncePhaseEnd>.Wrap(IGameEvent accessor) => new EventAnnouncePhaseEndImpl(accessor);

  static string ITypedGameEvent<EventAnnouncePhaseEnd>.GetName() => "announce_phase_end";

  static uint ITypedGameEvent<EventAnnouncePhaseEnd>.GetHash() => 0x5063C41Cu;
}
