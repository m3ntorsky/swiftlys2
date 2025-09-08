using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ColorAdjustHSL : CParticleFunctionOperator, IC_OP_ColorAdjustHSL {

  public C_OP_ColorAdjustHSL(nint handle) : base(handle) {
  }

  public IPerParticleFloatInput HueAdjust {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x34348E726B20DB80));
  }
  public IPerParticleFloatInput SaturationAdjust {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x34348E72D0C582F4));
  }
  public IPerParticleFloatInput LightnessAdjust {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x34348E72DC0100D5));
  }


}