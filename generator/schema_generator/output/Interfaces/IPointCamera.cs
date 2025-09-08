using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointCamera : IBaseEntity {

  public ref float FOV { get; }
  
  public ref float Resolution { get; }
  
  public ref bool FogEnable { get; }
  
  public ref Color FogColor { get; }
  
  public ref float FogStart { get; }
  
  public ref float FogEnd { get; }
  
  public ref float FogMaxDensity { get; }
  
  public ref bool Active { get; }
  
  public ref bool UseScreenAspectRatio { get; }
  
  public ref float AspectRatio { get; }
  
  public ref bool NoSky { get; }
  
  public ref float Brightness { get; }
  
  public ref float ZFar { get; }
  
  public ref float ZNear { get; }
  
  public ref bool CanHLTVUse { get; }
  
  public ref bool AlignWithParent { get; }
  
  public ref bool DofEnabled { get; }
  
  public ref float DofNearBlurry { get; }
  
  public ref float DofNearCrisp { get; }
  
  public ref float DofFarCrisp { get; }
  
  public ref float DofFarBlurry { get; }
  
  public ref float DofTiltToGround { get; }
  
  public ref float TargetFOV { get; }
  
  public ref float DegreesPerSecond { get; }
  
  public ref bool IsOn { get; }
  
  public IPointCamera Next { get; }
  
}