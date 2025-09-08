using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IClutterSceneObject_t : ISchemaClass {

  public IAABB_t Bounds { get; }
  
  public ref ObjectTypeFlags_t Flags { get; }
  
  public ref short Layer { get; }
  
  public ref CUtlVector<Vector> InstancePositions { get; }
  
  public ref CUtlVector<float> InstanceScales { get; }
  
  public ref CUtlVector<Color> InstanceTintSrgb { get; }
  
  public ref CUtlVector Tiles { get; }
  
  public CStrongHandle<IInfoForResourceTypeCModel> RenderableModel { get; }
  
  public ref CUtlStringToken MaterialGroup { get; }
  
  public ref float BeginCullSize { get; }
  
  public ref float EndCullSize { get; }
  
}