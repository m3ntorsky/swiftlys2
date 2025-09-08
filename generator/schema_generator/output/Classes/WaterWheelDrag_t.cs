using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class WaterWheelDrag_t : SchemaClass, IWaterWheelDrag_t {

  public WaterWheelDrag_t(nint handle) : base(handle) {
  }

  public ref float FractionOfWheelSubmerged {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x51DDFA66F2D4C09B));
  }
  public ref float WheelDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x51DDFA66B996F340));
  }


}