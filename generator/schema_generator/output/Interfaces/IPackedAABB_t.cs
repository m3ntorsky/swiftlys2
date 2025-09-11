using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPackedAABB_t : ISchemaClass {

  
  public ref uint PackedMin { get; }
  
  public ref uint PackedMax { get; }
}