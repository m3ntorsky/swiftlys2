using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmParameterizedBlendNode__Parameterization_t : ISchemaClass {

  public ref CUtlLeanVectorFixedGrowable<CNmParameterizedBlendNode::BlendRange_t,5> BlendRanges { get; }
  
  public ISchemaUntypedField ParameterRange { get; }
  
}