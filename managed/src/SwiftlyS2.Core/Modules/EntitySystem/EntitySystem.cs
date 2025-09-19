using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared.EntitySystem;

namespace SwiftlyS2.Core.EntitySystem;

internal class EntitySystemService : IEntitySystemService {

  public T CreateEntityByDesignerName<T>(string designerName) where T : ISchemaClass<T> {
    var handle = NativeEntitySystem.CreateEntityByName(designerName);
    if (handle == nint.Zero) {
      throw new ArgumentException($"Failed to create entity by designer name: {designerName}, probably invalid designer name");
    }
    return T.From(handle);
  }

  public CHandle<T> GetRefEHandle<T>(T entity) where T : class, ISchemaClass<T> {
    var handle = NativeEntitySystem.GetEntityHandleFromEntity(entity.GetHandle());
    return new CHandle<T> {
      Raw = handle,
    };
  }

  public CCSGameRules? GetGameRules() {
    var handle = NativeEntitySystem.GetGameRules();
    return handle.IsValidPtr() ? new CCSGameRulesImpl(handle) : null;
  }

}
