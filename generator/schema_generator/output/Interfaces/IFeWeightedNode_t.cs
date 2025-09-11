using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeWeightedNode_t : ISchemaClass {

  
  public ref ushort Node { get; }
  
  public ref ushort Weight { get; }
}