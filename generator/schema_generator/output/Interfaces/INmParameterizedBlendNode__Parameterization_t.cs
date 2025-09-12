using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmParameterizedBlendNode__Parameterization_t : ISchemaClass {

  
  public ISchemaUntypedField BlendRanges { get; }
  
  public ISchemaUntypedField ParameterRange { get; }
}