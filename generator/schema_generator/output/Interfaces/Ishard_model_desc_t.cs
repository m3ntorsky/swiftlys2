using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Ishard_model_desc_t : ISchemaClass {

  public ref int ModelID { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> MaterialBase { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> MaterialDamageOverlay { get; }
  
  public ref ShardSolid_t Solid { get; }
  
  public ref Vector2D PanelSize { get; }
  
  public ref Vector2D StressPositionA { get; }
  
  public ref Vector2D StressPositionB { get; }
  
  public ref CUtlVector<Vector2D> PanelVertices { get; }
  
  public ref CUtlVector<Vector4D> InitialPanelVertices { get; }
  
  public ref float GlassHalfThickness { get; }
  
  public ref bool HasParent { get; }
  
  public ref bool ParentFrozen { get; }
  
  public ref CUtlStringToken SurfacePropStringToken { get; }
  
}