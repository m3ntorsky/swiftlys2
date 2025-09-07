using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PermModelInfo_t : SchemaClass, IPermModelInfo_t {

  public PermModelInfo_t(nint handle) : base(handle) {
  }

  public PermModelInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1B48585FCE6E9C28));
  }
  public ref Vector HullMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1B48585FAC1193D6));
  }
  public ref Vector HullMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1B48585F9E269884));
  }
  public ref Vector ViewMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1B48585F22A936E8));
  }
  public ref Vector ViewMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1B48585F18BCAEE2));
  }
  public ref float Mass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1B48585FCD83D263));
  }
  public ref Vector EyePosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1B48585FA0F51EB1));
  }
  public ref float MaxEyeDeflection {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1B48585F1C6CE157));
  }
  public ref CUtlString SurfaceProperty {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x1B48585F1A25534C));
  }
  public ref CUtlString KeyValueText {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x1B48585F2156929E));
  }


}