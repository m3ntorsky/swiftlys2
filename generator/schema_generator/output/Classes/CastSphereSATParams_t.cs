using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CastSphereSATParams_t : SchemaClass, ICastSphereSATParams_t {

  public CastSphereSATParams_t(nint handle) : base(handle) {
  }

  public ref Vector RayStart {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6282EF48CB929F19));
  }
  public ref Vector RayDelta {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6282EF4874156D5B));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6282EF485ACFC08D));
  }
  public ref float MaxFraction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6282EF48BA58C801));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6282EF48B731A42F));
  }
  public IRnHull_t Hull {
    get => new RnHull_t(_Handle + Schema.GetOffset(0x6282EF48FAD20488));
  }


}