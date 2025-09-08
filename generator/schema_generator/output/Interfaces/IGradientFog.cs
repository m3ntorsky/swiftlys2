using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGradientFog : IBaseEntity {

  public ref CStrongHandle<InfoForResourceTypeCTextureBase> GradientFogTexture { get; }
  
  public ref float FogStartDistance { get; }
  
  public ref float FogEndDistance { get; }
  
  public ref bool HeightFogEnabled { get; }
  
  public ref float FogStartHeight { get; }
  
  public ref float FogEndHeight { get; }
  
  public ref float FarZ { get; }
  
  public ref float FogMaxOpacity { get; }
  
  public ref float FogFalloffExponent { get; }
  
  public ref float FogVerticalExponent { get; }
  
  public ref Color FogColor { get; }
  
  public ref float FogStrength { get; }
  
  public ref float FadeTime { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref bool IsEnabled { get; }
  
  public ref bool GradientFogNeedsTextures { get; }
  
}