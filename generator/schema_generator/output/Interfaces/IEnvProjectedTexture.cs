using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvProjectedTexture : IModelPointEntity {

  
  public ref CHandle<CBaseEntity> TargetEntity { get; }
  
  public ref bool State { get; }
  
  public ref bool AlwaysUpdate { get; }
  
  public ref float LightFOV { get; }
  
  public ref bool EnableShadows { get; }
  
  public ref bool SimpleProjection { get; }
  
  public ref bool LightOnlyTarget { get; }
  
  public ref bool LightWorld { get; }
  
  public ref bool CameraSpace { get; }
  
  public ref float BrightnessScale { get; }
  
  public ref Color LightColor { get; }
  
  public ref float Intensity { get; }
  
  public ref float LinearAttenuation { get; }
  
  public ref float QuadraticAttenuation { get; }
  
  public ref bool Volumetric { get; }
  
  public ref float NoiseStrength { get; }
  
  public ref float FlashlightTime { get; }
  
  public ref uint NumPlanes { get; }
  
  public ref float PlaneOffset { get; }
  
  public ref float VolumetricIntensity { get; }
  
  public ref float ColorTransitionTime { get; }
  
  public ref float Ambient { get; }
  
  public ISchemaFixedString SpotlightTextureName { get; }
  
  public ref int SpotlightTextureFrame { get; }
  
  public ref uint ShadowQuality { get; }
  
  public ref float NearZ { get; }
  
  public ref float FarZ { get; }
  
  public ref float ProjectionSize { get; }
  
  public ref float Rotation { get; }
  
  public ref bool FlipHorizontal { get; }
}