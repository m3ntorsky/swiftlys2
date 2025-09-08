using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_AgeNoise : CParticleFunctionInitializer, IC_INIT_AgeNoise {

  public C_INIT_AgeNoise(nint handle) : base(handle) {
  }

  public ref bool AbsVal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7155D6E1AD2CCF0A));
  }
  public ref bool AbsValInv {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7155D6E1024BCB79));
  }
  public ref float Offset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7155D6E17F14BA34));
  }
  public ref float AgeMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7155D6E11385AB42));
  }
  public ref float AgeMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7155D6E1FD7200E8));
  }
  public ref float NoiseScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7155D6E132FE2EF3));
  }
  public ref float NoiseScaleLoc {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7155D6E1A9F4B0DF));
  }
  public ref Vector OffsetLoc {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x7155D6E1EFAB26AC));
  }


}