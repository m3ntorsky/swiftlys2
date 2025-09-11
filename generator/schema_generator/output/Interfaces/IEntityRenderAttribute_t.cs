using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntityRenderAttribute_t : ISchemaClass {

  
  public ref CUtlStringToken ID { get; }
  
  public ref Vector4D Values { get; }
}