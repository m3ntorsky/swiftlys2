using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeTri_t : ISchemaClass {

  
  public ISchemaFixedArray<ushort> Node { get; }
  
  public ref float W1 { get; }
  
  public ref float W2 { get; }
  
  public ref float V1x { get; }
  
  public ref Vector2D V2 { get; }
}