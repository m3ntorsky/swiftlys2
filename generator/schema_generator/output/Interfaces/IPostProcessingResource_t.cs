using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPostProcessingResource_t : ISchemaClass {

  public ref bool HasTonemapParams { get; }
  
  public IPostProcessingTonemapParameters_t ToneMapParams { get; }
  
  public ref bool HasBloomParams { get; }
  
  public IPostProcessingBloomParameters_t BloomParams { get; }
  
  public ref bool HasVignetteParams { get; }
  
  public IPostProcessingVignetteParameters_t VignetteParams { get; }
  
  public ref bool HasLocalContrastParams { get; }
  
  public IPostProcessingLocalContrastParameters_t LocalConstrastParams { get; }
  
  public ref int ColorCorrectionVolumeDim { get; }
  
  public ref CUtlBinaryBlock ColorCorrectionVolumeData { get; }
  
  public ref bool HasColorCorrection { get; }
  
  public ref bool HasFogScatteringParams { get; }
  
  public IPostProcessingFogScatteringParameters_t FogScatteringParams { get; }
  
}