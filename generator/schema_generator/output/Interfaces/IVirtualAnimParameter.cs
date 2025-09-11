using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVirtualAnimParameter : IAnimParameterBase {

  
  public ref CUtlString ExpressionString { get; }
  
  public ref AnimParamType_t ParamType { get; }
}