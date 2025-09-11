using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParamSpanUpdater : ISchemaClass {

  
// CUtlVector< ParamSpan_t >
  public ref CUtlVector Spans { get; }
}