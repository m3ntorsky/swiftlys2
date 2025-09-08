using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PostProcessingFogScatteringParameters_t : SchemaClass, IPostProcessingFogScatteringParameters_t {

  public PostProcessingFogScatteringParameters_t(nint handle) : base(handle) {
  }

  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAE3B2EF52E1F6E07));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAE3B2EF555E6EFAD));
  }
  public ref float CubemapScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAE3B2EF593A389D0));
  }
  public ref float VolumetricScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAE3B2EF515A15A21));
  }
  public ref float GradientScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAE3B2EF58473F465));
  }


}