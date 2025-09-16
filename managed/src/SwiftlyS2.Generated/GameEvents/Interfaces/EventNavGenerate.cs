using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "nav_generate"
/// </summary>
public interface EventNavGenerate : IGameEvent<EventNavGenerate> {

  static EventNavGenerate IGameEvent<EventNavGenerate>.FromAllocated(nint ptr) => new EventNavGenerateImpl(ptr, true);

  static EventNavGenerate IGameEvent<EventNavGenerate>.FromExternal(nint ptr) => new EventNavGenerateImpl(ptr, false);

  static string IGameEvent<EventNavGenerate>.GetName() => "nav_generate";

  static uint IGameEvent<EventNavGenerate>.GetHash() => 0x06197C30u;
}
