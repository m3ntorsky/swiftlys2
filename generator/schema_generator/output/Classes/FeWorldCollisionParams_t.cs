using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeWorldCollisionParams_t : SchemaClass, IFeWorldCollisionParams_t {

  public FeWorldCollisionParams_t(nint handle) : base(handle) {
  }

  public ref float WorldFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85D16E65E1266C23));
  }
  public ref float GroundFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85D16E652D394B72));
  }
  public ref ushort ListBegin {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x85D16E650BA98846));
  }
  public ref ushort ListEnd {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x85D16E658683DD62));
  }


}