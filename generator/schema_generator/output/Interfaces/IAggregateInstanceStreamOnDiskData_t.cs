using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAggregateInstanceStreamOnDiskData_t : ISchemaClass {

  public ref uint DecodedSize { get; }
  
  public ref CUtlBinaryBlock BufferData { get; }
  
}