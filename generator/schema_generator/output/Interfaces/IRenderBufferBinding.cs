using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRenderBufferBinding : ISchemaClass {

  
  public ref ulong Buffer { get; }
  
  public ref uint BindOffsetBytes { get; }
}