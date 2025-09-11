using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmBitFlags : ISchemaClass {

  
  public ref uint Flags { get; }
}