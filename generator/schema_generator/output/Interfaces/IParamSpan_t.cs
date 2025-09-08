using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParamSpan_t : ISchemaClass {

  public ref CUtlVector Samples { get; }
  
  public IAnimParamHandle Param { get; }
  
  public ref AnimParamType_t ParamType { get; }
  
  public ref float StartCycle { get; }
  
  public ref float EndCycle { get; }
  
}