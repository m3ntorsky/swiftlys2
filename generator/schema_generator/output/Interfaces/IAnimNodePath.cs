using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimNodePath : ISchemaClass {

  
  public IAnimNodeID Path { get; }
  
  public ref int Count { get; }
}