using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimComponentID : ISchemaClass {

  
  public ref uint Id { get; }
}