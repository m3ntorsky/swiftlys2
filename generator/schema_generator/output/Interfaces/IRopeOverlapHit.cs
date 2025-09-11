using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRopeOverlapHit : ISchemaClass {

  
  public ref CHandle<CBaseEntity> Entity { get; }
  
  public ref CUtlVector<int> OverlappingLinks { get; }
}