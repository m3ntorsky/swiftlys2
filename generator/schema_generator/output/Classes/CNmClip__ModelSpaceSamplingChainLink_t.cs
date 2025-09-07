using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmClip__ModelSpaceSamplingChainLink_t : SchemaClass, INmClip__ModelSpaceSamplingChainLink_t {

  public CNmClip__ModelSpaceSamplingChainLink_t(nint handle) : base(handle) {
  }

  public CNmClip__ModelSpaceSamplingChainLink_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int BoneIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAFAB55410E26A9C2));
  }
  public ref int ParentBoneIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAFAB554185076542));
  }
  public ref int ParentChainLinkIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAFAB5541DB4E7C5D));
  }


}