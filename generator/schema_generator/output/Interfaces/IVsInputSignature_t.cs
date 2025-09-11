using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVsInputSignature_t : ISchemaClass {

  
// CUtlVector< VsInputSignatureElement_t >
  public ref CUtlVector Elems { get; }
  
// CUtlVector< VsInputSignatureElement_t >
  public ref CUtlVector Depth_elems { get; }
}