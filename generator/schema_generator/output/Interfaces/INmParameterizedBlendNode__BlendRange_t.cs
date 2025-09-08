using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmParameterizedBlendNode__BlendRange_t : ISchemaClass {

  public ref short InputIdx0 { get; }
  
  public ref short InputIdx1 { get; }
  
  public ISchemaUntypedField ParameterValueRange { get; }
  
}