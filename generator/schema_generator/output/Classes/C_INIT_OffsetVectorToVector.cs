using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_OffsetVectorToVector : CParticleFunctionInitializer, IC_INIT_OffsetVectorToVector {

  public C_INIT_OffsetVectorToVector(nint handle) : base(handle) {
  }

  public C_INIT_OffsetVectorToVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x36502BDCAE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x36502BDCE5729606));
  }
  public ref Vector OutputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x36502BDC2EFED678));
  }
  public ref Vector OutputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x36502BDC451280D2));
  }
  public IRandomNumberGeneratorParameters RandomnessParameters {
    get => new CRandomNumberGeneratorParameters(_Handle + Schema.GetOffset(0x36502BDC7EDF50AD));
  }


}