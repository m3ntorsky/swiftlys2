using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITextureBasedAnimatable : IBaseModelEntity {

  public ref bool Loop { get; }
  
  public ref float FPS { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> PositionKeys { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> RotationKeys { get; }
  
  public ref Vector AnimationBoundsMin { get; }
  
  public ref Vector AnimationBoundsMax { get; }
  
  public ref float StartTime { get; }
  
  public ref float StartFrame { get; }
  
}