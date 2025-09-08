using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvVolumetricFogController : IBaseEntity {

  public ref float Scattering { get; }
  
  public ref Color TintColor { get; }
  
  public ref float Anisotropy { get; }
  
  public ref float FadeSpeed { get; }
  
  public ref float DrawDistance { get; }
  
  public ref float FadeInStart { get; }
  
  public ref float FadeInEnd { get; }
  
  public ref float IndirectStrength { get; }
  
  public ref int VolumeDepth { get; }
  
  public ref float FirstVolumeSliceThickness { get; }
  
  public ref int IndirectTextureDimX { get; }
  
  public ref int IndirectTextureDimY { get; }
  
  public ref int IndirectTextureDimZ { get; }
  
  public ref Vector BoxMins { get; }
  
  public ref Vector BoxMaxs { get; }
  
  public ref bool Active { get; }
  
  public IGameTime_t StartAnisoTime { get; }
  
  public IGameTime_t StartScatterTime { get; }
  
  public IGameTime_t StartDrawDistanceTime { get; }
  
  public ref float StartAnisotropy { get; }
  
  public ref float StartScattering { get; }
  
  public ref float StartDrawDistance { get; }
  
  public ref float DefaultAnisotropy { get; }
  
  public ref float DefaultScattering { get; }
  
  public ref float DefaultDrawDistance { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref bool EnableIndirect { get; }
  
  public ref bool IsMaster { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> FogIndirectTexture { get; }
  
  public ref int ForceRefreshCount { get; }
  
  public ref float NoiseSpeed { get; }
  
  public ref float NoiseStrength { get; }
  
  public ref Vector NoiseScale { get; }
  
  public ref float WindSpeed { get; }
  
  public ref Vector WindDirection { get; }
  
  public ref bool FirstTime { get; }
  
}