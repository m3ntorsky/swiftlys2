using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPostProcessingVolume : IBaseTrigger {

  
  public ref CStrongHandle<InfoForResourceTypeCPostProcessingResource> PostSettings { get; }
  
  public ref float FadeDuration { get; }
  
  public ref float MinLogExposure { get; }
  
  public ref float MaxLogExposure { get; }
  
  public ref float MinExposure { get; }
  
  public ref float MaxExposure { get; }
  
  public ref float ExposureCompensation { get; }
  
  public ref float ExposureFadeSpeedUp { get; }
  
  public ref float ExposureFadeSpeedDown { get; }
  
  public ref float TonemapEVSmoothingRange { get; }
  
  public ref bool Master { get; }
  
  public ref bool ExposureControl { get; }
}