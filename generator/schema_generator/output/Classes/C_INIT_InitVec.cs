using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitVec : CParticleFunctionInitializer, IC_INIT_InitVec {

  public C_INIT_InitVec(nint handle) : base(handle) {
  }

  public C_INIT_InitVec(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleVecInput InputValue {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x60C95B0234445438));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x60C95B02324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x60C95B02FB53C31E));
  }
  public ref bool NormalizedOutput {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x60C95B020AA98C55));
  }
  public ref bool WritePreviousPosition {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x60C95B02EA635776));
  }


}