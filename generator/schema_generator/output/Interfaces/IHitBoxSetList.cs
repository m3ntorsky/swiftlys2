using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHitBoxSetList : ISchemaClass {

  
// CUtlVector< CHitBoxSet >
  public ref CUtlVector HitBoxSets { get; }
}