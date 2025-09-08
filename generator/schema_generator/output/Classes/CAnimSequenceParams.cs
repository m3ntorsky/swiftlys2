using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimSequenceParams : SchemaClass, IAnimSequenceParams {

  public CAnimSequenceParams(nint handle) : base(handle) {
  }

  public ref float FadeInTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x651691F81F0255B3));
  }
  public ref float FadeOutTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x651691F8E86D2FC2));
  }


}