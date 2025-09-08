using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDrawCullingData : ISchemaClass {

  public ISchemaFixedArray<byte> ConeAxis { get; }
  
  public ref byte ConeCutoff { get; }
  
}