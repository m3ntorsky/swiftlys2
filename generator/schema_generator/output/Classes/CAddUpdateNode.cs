using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAddUpdateNode : CBinaryUpdateNode, IAddUpdateNode {

  public CAddUpdateNode(nint handle) : base(handle) {
  }

  public ref BinaryNodeChildOption FootMotionTiming {
    get => ref _Handle.AsRef<BinaryNodeChildOption>(Schema.GetOffset(0x607346F4BB17F13D));
  }
  public ref bool ApplyToFootMotion {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x607346F43D831E94));
  }
  public ref bool ApplyChannelsSeparately {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x607346F4FF2DBB45));
  }
  public ref bool UseModelSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x607346F448863521));
  }
  public ref bool ApplyScale {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x607346F469D11233));
  }


}