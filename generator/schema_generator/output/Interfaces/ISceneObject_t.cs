using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISceneObject_t : ISchemaClass {

  public ref uint ObjectID { get; }
  
  public ISchemaFixedArray<Vector4D> Transform { get; }
  
  public ref float FadeStartDistance { get; }
  
  public ref float FadeEndDistance { get; }
  
  public ref Vector4D TintColor { get; }
  
  public ref CUtlString Skin { get; }
  
  public ref ObjectTypeFlags_t ObjectTypeFlags { get; }
  
  public ref Vector LightingOrigin { get; }
  
  public ref short OverlayRenderOrder { get; }
  
  public ref short LODOverride { get; }
  
  public ref int CubeMapPrecomputedHandshake { get; }
  
  public ref int LightProbeVolumePrecomputedHandshake { get; }
  
  public CStrongHandle<IInfoForResourceTypeCModel> RenderableModel { get; }
  
  public CStrongHandle<IInfoForResourceTypeCRenderMesh> Renderable { get; }
  
}