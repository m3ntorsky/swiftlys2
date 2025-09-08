using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeQuad_t : ISchemaClass {

  public ISchemaFixedArray<ushort> Node { get; }
  
  public ref float Slack { get; }
  
  public ISchemaFixedArray<Vector4D> Shape { get; }
  
}