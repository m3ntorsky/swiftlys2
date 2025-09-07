using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetFloat : CParticleFunctionOperator, IC_OP_SetFloat {

  public C_OP_SetFloat(nint handle) : base(handle) {
  }

  public C_OP_SetFloat(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput InputValue {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF719E43734445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF719E437324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0xF719E437FB53C31E));
  }
  public IPerParticleFloatInput Lerp {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF719E4375C17F8E8));
  }


}