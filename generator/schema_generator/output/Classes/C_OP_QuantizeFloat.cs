using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_QuantizeFloat : CParticleFunctionOperator, IC_OP_QuantizeFloat {

  public C_OP_QuantizeFloat(nint handle) : base(handle) {
  }

  public C_OP_QuantizeFloat(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput InputValue {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xCD85375434445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xCD853754324F6F74));
  }


}