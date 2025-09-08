using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionSchema : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref ActionType_t ActionType { get; }
  
  public ref ActionType_t ActionInstanceType { get; }
  
}