using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvViewPunch : CPointEntity, IEnvViewPunch {

  public CEnvViewPunch(nint handle) : base(handle) {
  }

  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB707E1B05ACFC08D));
  }
  public ref QAngle ViewPunch {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xB707E1B0061B7CBA));
  }


}