using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderLights : C_OP_RenderPoints, IC_OP_RenderLights {

  public C_OP_RenderLights(nint handle) : base(handle) {
  }

  public ref float AnimationRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x534FF0BC607083AD));
  }
  public ref AnimationType_t AnimationType {
    get => ref _Handle.AsRef<AnimationType_t>(Schema.GetOffset(0x534FF0BCB93FDFD1));
  }
  public ref bool AnimateInFPS {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x534FF0BC7C271B16));
  }
  public ref float MinSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x534FF0BCBDC3B198));
  }
  public ref float MaxSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x534FF0BC8CA4E6BE));
  }
  public ref float StartFadeSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x534FF0BCBA251D92));
  }
  public ref float EndFadeSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x534FF0BC2D3FD423));
  }


}