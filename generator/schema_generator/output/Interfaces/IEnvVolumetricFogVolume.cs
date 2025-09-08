using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvVolumetricFogVolume : IBaseEntity {

  public ref bool Active { get; }
  
  public ref Vector BoxMins { get; }
  
  public ref Vector BoxMaxs { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref bool IndirectUseLPVs { get; }
  
  public ref float Strength { get; }
  
  public ref int FalloffShape { get; }
  
  public ref float FalloffExponent { get; }
  
  public ref float HeightFogDepth { get; }
  
  public ref float HeightFogEdgeWidth { get; }
  
  public ref float IndirectLightStrength { get; }
  
  public ref float SunLightStrength { get; }
  
  public ref float NoiseStrength { get; }
  
  public ref Color TintColor { get; }
  
  public ref bool OverrideTintColor { get; }
  
  public ref bool OverrideIndirectLightStrength { get; }
  
  public ref bool OverrideSunLightStrength { get; }
  
  public ref bool OverrideNoiseStrength { get; }
  
}