using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_VelocityFromNormal : CParticleFunctionInitializer, IC_INIT_VelocityFromNormal {

  public C_INIT_VelocityFromNormal(nint handle) : base(handle) {
  }

  public C_INIT_VelocityFromNormal(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float SpeedMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x33D27066B989E1F8));
  }
  public ref float SpeedMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x33D27066CF9D8C52));
  }
  public ref bool IgnoreDt {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x33D27066330C0603));
  }


}