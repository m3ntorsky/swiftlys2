using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRegionSVM : ISchemaClass {

  
// CUtlVector< RnPlane_t >
  public ref CUtlVector Planes { get; }
  
  public ref CUtlVector<uint> Nodes { get; }
}