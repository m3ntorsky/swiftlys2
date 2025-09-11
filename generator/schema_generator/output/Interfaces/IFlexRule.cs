using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFlexRule : ISchemaClass {

  
  public ref int Flex { get; }
  
// CUtlVector< CFlexOp >
  public ref CUtlVector FlexOps { get; }
}