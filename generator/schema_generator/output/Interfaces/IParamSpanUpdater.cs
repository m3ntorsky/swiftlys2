using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParamSpanUpdater : ISchemaClass {

  public ref CUtlVector Spans { get; }
  
}