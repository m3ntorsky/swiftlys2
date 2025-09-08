using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimBone : SchemaClass, IAnimBone {

  public CAnimBone(nint handle) : base(handle) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x891F6AB94D8F5786));
  }
  public ref int Parent {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x891F6AB92FF7A69D));
  }
  public ref Vector Pos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x891F6AB944CEBEA9));
  }
  public ref QuaternionStorage Quat {
    get => ref _Handle.AsRef<QuaternionStorage>(Schema.GetOffset(0x891F6AB9157658BE));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x891F6AB9C2A44391));
  }
  public ref QuaternionStorage Alignment {
    get => ref _Handle.AsRef<QuaternionStorage>(Schema.GetOffset(0x891F6AB9CA0E45D1));
  }
  public ref int Flags {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x891F6AB9DC74A14C));
  }


}