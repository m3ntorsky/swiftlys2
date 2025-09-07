using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSubtractUpdateNode : CBinaryUpdateNode, ISubtractUpdateNode {

  public CSubtractUpdateNode(nint handle) : base(handle) {
  }

  public CSubtractUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref BinaryNodeChildOption FootMotionTiming {
    get => ref _Handle.AsRef<BinaryNodeChildOption>(Schema.GetOffset(0x108B5B3FBB17F13D));
  }
  public ref bool ApplyToFootMotion {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x108B5B3F3D831E94));
  }
  public ref bool ApplyChannelsSeparately {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x108B5B3FFF2DBB45));
  }
  public ref bool UseModelSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x108B5B3F48863521));
  }


}