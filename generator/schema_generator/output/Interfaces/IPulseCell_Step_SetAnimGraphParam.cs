using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Step_SetAnimGraphParam : IPulseCell_BaseFlow {

  
  public ref CUtlString ParamName { get; }
}