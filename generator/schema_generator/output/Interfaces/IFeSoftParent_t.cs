using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSoftParent_t : ISchemaClass {

  public ref int Parent { get; }
  
  public ref float Alpha { get; }
  
}