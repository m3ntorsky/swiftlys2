using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetVec : CParticleFunctionOperator, IC_OP_SetVec {

  public C_OP_SetVec(nint handle) : base(handle) {
  }

  public C_OP_SetVec(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleVecInput InputValue {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x24E155B734445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x24E155B7324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x24E155B7FB53C31E));
  }
  public IPerParticleFloatInput Lerp {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x24E155B75C17F8E8));
  }
  public ref bool NormalizedOutput {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x24E155B70AA98C55));
  }


}