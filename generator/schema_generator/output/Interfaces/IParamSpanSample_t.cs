using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParamSpanSample_t : ISchemaClass {

  
  public ISchemaUntypedField Value { get; }
  
  public ref float Cycle { get; }
}