using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeKelagerBend2_t : ISchemaClass {

  
  public ISchemaFixedArray<float> Weight { get; }
  
  public ref float Height0 { get; }
  
  public ISchemaFixedArray<ushort> Node { get; }
  
  public ref ushort Reserved { get; }
}