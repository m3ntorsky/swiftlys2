using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITextureBasedAnimatable : IBaseModelEntity {

  public ref bool Loop { get; }
  
  public ref float FPS { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> PositionKeys { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> RotationKeys { get; }
  
  public ref Vector AnimationBoundsMin { get; }
  
  public ref Vector AnimationBoundsMax { get; }
  
  public ref float StartTime { get; }
  
  public ref float StartFrame { get; }
  
}