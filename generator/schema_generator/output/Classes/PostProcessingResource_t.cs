using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PostProcessingResource_t : SchemaClass, IPostProcessingResource_t {

  public PostProcessingResource_t(nint handle) : base(handle) {
  }

  public ref bool HasTonemapParams {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x81127543E6A6D70D));
  }
  public IPostProcessingTonemapParameters_t ToneMapParams {
    get => new PostProcessingTonemapParameters_t(_Handle + Schema.GetOffset(0x811275437AD3669B));
  }
  public ref bool HasBloomParams {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x81127543754C1410));
  }
  public IPostProcessingBloomParameters_t BloomParams {
    get => new PostProcessingBloomParameters_t(_Handle + Schema.GetOffset(0x81127543CEC3092A));
  }
  public ref bool HasVignetteParams {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x81127543593E9813));
  }
  public IPostProcessingVignetteParameters_t VignetteParams {
    get => new PostProcessingVignetteParameters_t(_Handle + Schema.GetOffset(0x81127543FBBFC5B9));
  }
  public ref bool HasLocalContrastParams {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x81127543247F8B76));
  }
  public IPostProcessingLocalContrastParameters_t LocalConstrastParams {
    get => new PostProcessingLocalContrastParameters_t(_Handle + Schema.GetOffset(0x811275437AB7080F));
  }
  public ref int ColorCorrectionVolumeDim {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x81127543BF8A2F78));
  }
  public ref CUtlBinaryBlock ColorCorrectionVolumeData {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0x81127543211CF8FA));
  }
  public ref bool HasColorCorrection {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x811275434EDD24C6));
  }
  public ref bool HasFogScatteringParams {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x81127543EBB4887D));
  }
  public IPostProcessingFogScatteringParameters_t FogScatteringParams {
    get => new PostProcessingFogScatteringParameters_t(_Handle + Schema.GetOffset(0x8112754373861903));
  }


}