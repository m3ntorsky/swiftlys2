using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvParticleGlow : IParticleSystem {

  public ref float AlphaScale { get; }
  
  public ref float RadiusScale { get; }
  
  public ref float SelfIllumScale { get; }
  
  public ref Color ColorTint { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureOverride { get; }
  
}