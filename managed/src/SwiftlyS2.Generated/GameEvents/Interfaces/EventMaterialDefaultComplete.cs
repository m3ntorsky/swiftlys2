using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "material_default_complete"
/// </summary>
public interface EventMaterialDefaultComplete : IGameEvent<EventMaterialDefaultComplete> {

  static EventMaterialDefaultComplete IGameEvent<EventMaterialDefaultComplete>.FromAllocated(nint ptr) => new EventMaterialDefaultCompleteImpl(ptr, true);

  static EventMaterialDefaultComplete IGameEvent<EventMaterialDefaultComplete>.FromExternal(nint ptr) => new EventMaterialDefaultCompleteImpl(ptr, false);

  static string IGameEvent<EventMaterialDefaultComplete>.GetName() => "material_default_complete";

  static uint IGameEvent<EventMaterialDefaultComplete>.GetHash() => 0x6235E5E8u;
}
