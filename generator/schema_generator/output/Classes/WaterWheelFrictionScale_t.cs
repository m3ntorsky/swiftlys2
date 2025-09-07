using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class WaterWheelFrictionScale_t : SchemaClass, IWaterWheelFrictionScale_t {

  public WaterWheelFrictionScale_t(nint handle) : base(handle) {
  }

  public WaterWheelFrictionScale_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float FractionOfWheelSubmerged {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x79315E8EF2D4C09B));
  }
  public ref float FrictionScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x79315E8ECB7D1875));
  }


}