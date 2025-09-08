using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimParamHandle : ISchemaClass {

  public ref AnimParamType_t Type { get; }
  
  public ref byte Index { get; }
  
}