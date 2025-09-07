using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PostProcessingLocalContrastParameters_t : SchemaClass, IPostProcessingLocalContrastParameters_t {

  public PostProcessingLocalContrastParameters_t(nint handle) : base(handle) {
  }

  public PostProcessingLocalContrastParameters_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float LocalContrastStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43910BD66A89DF05));
  }
  public ref float LocalContrastEdgeStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43910BD6CC517324));
  }
  public ref float LocalContrastVignetteStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43910BD633264BD6));
  }
  public ref float LocalContrastVignetteEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43910BD689634873));
  }
  public ref float LocalContrastVignetteBlur {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43910BD6D8C40957));
  }


}