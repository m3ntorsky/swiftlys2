using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeNodeReverseOffset_t : SchemaClass, IFeNodeReverseOffset_t {

  public FeNodeReverseOffset_t(nint handle) : base(handle) {
  }

  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA3D68D6AB2913856));
  }
  public ref ushort BoneCtrl {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA3D68D6AE9730872));
  }
  public ref ushort TargetNode {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA3D68D6A817BD540));
  }


}