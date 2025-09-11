using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoOverlayData_t : ISchemaClass {

  
  public ref matrix3x4_t Transform { get; }
  
  public ref float Width { get; }
  
  public ref float Height { get; }
  
  public ref float Depth { get; }
  
  public ref Vector2D UVStart { get; }
  
  public ref Vector2D UVEnd { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material { get; }
  
  public ref int RenderOrder { get; }
  
  public ref Vector4D TintColor { get; }
  
  public ref CUtlStringToken SequenceOverrideName { get; }
}