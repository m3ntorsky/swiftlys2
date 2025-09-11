using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFlexOp : ISchemaClass {

  
  public ref FlexOpCode_t OpCode { get; }
  
  public ref int Data { get; }
}