using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FollowTargetOpFixedSettings_t : SchemaClass, IFollowTargetOpFixedSettings_t {

  public FollowTargetOpFixedSettings_t(nint handle) : base(handle) {
  }

  public FollowTargetOpFixedSettings_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int BoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF6423DF66AFA4155));
  }
  public ref bool BoneTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6423DF60E626FD2));
  }
  public ref int BoneTargetIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF6423DF62218DF46));
  }
  public ref bool WorldCoodinateTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6423DF60B5B2B16));
  }
  public ref bool MatchTargetOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF6423DF642E0C3DB));
  }


}