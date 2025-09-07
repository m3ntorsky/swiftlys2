using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimKeyData : SchemaClass, IAnimKeyData {

  public CAnimKeyData(nint handle) : base(handle) {
  }

  public CAnimKeyData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x790610E24D8F5786));
  }
  public ref CUtlVector< CAnimBone > BoneArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimBone >>(Schema.GetOffset(0x790610E280273F0C));
  }
  public ref CUtlVector< CAnimUser > UserArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimUser >>(Schema.GetOffset(0x790610E2FBDB0C13));
  }
  public ref CUtlVector< CBufferString > MorphArray {
    get => ref _Handle.AsRef<CUtlVector< CBufferString >>(Schema.GetOffset(0x790610E28C6827E6));
  }
  public ref int ChannelElements {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x790610E20D1DA989));
  }
  public ref CUtlVector< CAnimDataChannelDesc > DataChannelArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimDataChannelDesc >>(Schema.GetOffset(0x790610E2D1641EB9));
  }


}