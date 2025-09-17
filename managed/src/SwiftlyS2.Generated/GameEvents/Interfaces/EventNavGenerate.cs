using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "nav_generate"
/// </summary>
public interface EventNavGenerate : ITypedGameEvent<EventNavGenerate> {

  static EventNavGenerate ITypedGameEvent<EventNavGenerate>.Wrap(IGameEvent accessor) => new EventNavGenerateImpl(accessor);

  static string ITypedGameEvent<EventNavGenerate>.GetName() => "nav_generate";

  static uint ITypedGameEvent<EventNavGenerate>.GetHash() => 0x06197C30u;
}
