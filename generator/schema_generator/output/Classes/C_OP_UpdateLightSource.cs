using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_UpdateLightSource : CParticleFunctionOperator, IC_OP_UpdateLightSource {

  public C_OP_UpdateLightSource(nint handle) : base(handle) {
  }

  public ref Color ColorTint {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x6611EEDD569A6EA9));
  }
  public ref float BrightnessScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6611EEDD5EFC3AAE));
  }
  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6611EEDDA7A20159));
  }
  public ref float MinimumLightingRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6611EEDD946ABF7B));
  }
  public ref float MaximumLightingRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6611EEDD8804B57D));
  }
  public ref float PositionDampingConstant {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6611EEDD074C2A6A));
  }


}