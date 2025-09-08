using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncTimescale : CBaseEntity, IFuncTimescale {

  public CFuncTimescale(nint handle) : base(handle) {
  }

  public ref float DesiredTimescale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93388D41E4EE9A68));
  }
  public ref float Acceleration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93388D41071E739B));
  }
  public ref float MinBlendRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93388D41E90D5E26));
  }
  public ref float BlendDeltaMultiplier {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93388D413D2158F7));
  }
  public ref bool IsStarted {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x93388D41C4A4378E));
  }


}