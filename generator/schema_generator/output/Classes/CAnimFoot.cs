using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimFoot : SchemaClass, IAnimFoot {

  public CAnimFoot(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x583A05E34D8F5786));
  }
  public ref Vector BallOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x583A05E3E3376F1B));
  }
  public ref Vector HeelOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x583A05E3306AE608));
  }
  public ref int AnkleBoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x583A05E31E89F146));
  }
  public ref int ToeBoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x583A05E3EEF7CC57));
  }


}