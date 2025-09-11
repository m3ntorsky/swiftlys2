using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimDecoder : ISchemaClass {

  
  public ref CBufferString Name { get; }
  
  public ref int Version { get; }
  
  public ref int Type { get; }
}