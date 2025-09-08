using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVsInputSignature_t : ISchemaClass {

  public ref CUtlVector Elems { get; }
  
  public ref CUtlVector Depth_elems { get; }
  
}