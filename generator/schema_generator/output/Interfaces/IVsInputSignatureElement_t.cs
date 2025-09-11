using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVsInputSignatureElement_t : ISchemaClass {

  
  public ISchemaFixedString Name { get; }
  
  public ISchemaFixedString Semantic { get; }
  
  public ISchemaFixedString D3DSemanticName { get; }
  
  public ref int D3DSemanticIndex { get; }
}