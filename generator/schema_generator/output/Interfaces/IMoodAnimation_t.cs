using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMoodAnimation_t : ISchemaClass {

  public ISchemaUntypedField Name { get; }
  
  public ref float Weight { get; }
  
}