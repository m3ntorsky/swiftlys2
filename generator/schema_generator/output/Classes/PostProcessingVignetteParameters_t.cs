using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PostProcessingVignetteParameters_t : SchemaClass, IPostProcessingVignetteParameters_t {

  public PostProcessingVignetteParameters_t(nint handle) : base(handle) {
  }

  public ref float VignetteStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC31FEB45110C062C));
  }
  public ref Vector2D Center {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xC31FEB45C82A5908));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC31FEB455ACFC08D));
  }
  public ref float Roundness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC31FEB453987DB42));
  }
  public ref float Feather {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC31FEB455070E146));
  }
  public ref Vector ColorTint {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC31FEB45569A6EA9));
  }


}