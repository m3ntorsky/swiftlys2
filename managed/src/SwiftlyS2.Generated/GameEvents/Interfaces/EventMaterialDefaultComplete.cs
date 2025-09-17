using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "material_default_complete"
/// </summary>
public interface EventMaterialDefaultComplete : ITypedGameEvent<EventMaterialDefaultComplete> {

  static EventMaterialDefaultComplete ITypedGameEvent<EventMaterialDefaultComplete>.Create() => new EventMaterialDefaultCompleteImpl();

  static string ITypedGameEvent<EventMaterialDefaultComplete>.GetName() => "material_default_complete";

  static uint ITypedGameEvent<EventMaterialDefaultComplete>.GetHash() => 0x6235E5E8u;
}
