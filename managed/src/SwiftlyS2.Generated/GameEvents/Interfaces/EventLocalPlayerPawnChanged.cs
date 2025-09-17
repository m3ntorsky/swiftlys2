using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "local_player_pawn_changed"
/// </summary>
public interface EventLocalPlayerPawnChanged : ITypedGameEvent<EventLocalPlayerPawnChanged> {

  static EventLocalPlayerPawnChanged ITypedGameEvent<EventLocalPlayerPawnChanged>.Wrap(IGameEvent accessor) => new EventLocalPlayerPawnChangedImpl(accessor);

  static string ITypedGameEvent<EventLocalPlayerPawnChanged>.GetName() => "local_player_pawn_changed";

  static uint ITypedGameEvent<EventLocalPlayerPawnChanged>.GetHash() => 0x4703D4F0u;
}
