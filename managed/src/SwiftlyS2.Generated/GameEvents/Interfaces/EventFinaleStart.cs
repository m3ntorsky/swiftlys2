using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "finale_start"
/// </summary>
public interface EventFinaleStart : ITypedGameEvent<EventFinaleStart> {

  static EventFinaleStart ITypedGameEvent<EventFinaleStart>.Wrap(IGameEvent accessor) => new EventFinaleStartImpl(accessor);

  static string ITypedGameEvent<EventFinaleStart>.GetName() => "finale_start";

  static uint ITypedGameEvent<EventFinaleStart>.GetHash() => 0xA8BF9A49u;
  /// <summary>
  /// type: short
  /// </summary>
  short Rushes { get; set; }

}
