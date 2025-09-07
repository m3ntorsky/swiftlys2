using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LazyCullCompareFloat : CParticleFunctionOperator, IC_OP_LazyCullCompareFloat {

  public C_OP_LazyCullCompareFloat(nint handle) : base(handle) {
  }

  public C_OP_LazyCullCompareFloat(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput Comparsion1 {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9D0DCAD079865299));
  }
  public IPerParticleFloatInput Comparsion2 {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9D0DCAD076864DE0));
  }
  public IPerParticleFloatInput CullTime {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9D0DCAD0AE2A76FA));
  }


}