using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPostProcessingBloomParameters_t : ISchemaClass {

  public ref BloomBlendMode_t BlendMode { get; }
  
  public ref float BloomStrength { get; }
  
  public ref float ScreenBloomStrength { get; }
  
  public ref float BlurBloomStrength { get; }
  
  public ref float BloomThreshold { get; }
  
  public ref float BloomThresholdWidth { get; }
  
  public ref float SkyboxBloomStrength { get; }
  
  public ref float BloomStartValue { get; }
  
  public ref float ComputeBloomStrength { get; }
  
  public ref float ComputeBloomThreshold { get; }
  
  public ref float ComputeBloomRadius { get; }
  
  public ref float ComputeBloomEffectsScale { get; }
  
  public ref float ComputeBloomLensDirtStrength { get; }
  
  public ref float ComputeBloomLensDirtBlackLevel { get; }
  
  public ISchemaFixedArray<float> BlurWeight { get; }
  
  public ISchemaFixedArray<Vector> BlurTint { get; }
  
}