using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IExtent : ISchemaClass {

  
  public ref Vector Lo { get; }
  
  public ref Vector Hi { get; }
}