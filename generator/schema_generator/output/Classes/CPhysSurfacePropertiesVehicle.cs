using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysSurfacePropertiesVehicle : SchemaClass, IPhysSurfacePropertiesVehicle {

  public CPhysSurfacePropertiesVehicle(nint handle) : base(handle) {
  }

  public CPhysSurfacePropertiesVehicle(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float WheelDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5B1104DCC04986AE));
  }
  public ref float WheelFrictionScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5B1104DC7A6D9A4C));
  }


}