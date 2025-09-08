using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimParamID : ISchemaClass {

  public ref uint Id { get; }
  
}