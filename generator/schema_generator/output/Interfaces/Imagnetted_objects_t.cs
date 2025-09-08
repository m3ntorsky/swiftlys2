using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Imagnetted_objects_t : ISchemaClass {

  public ref CHandle<CBaseEntity> Entity { get; }
  
}