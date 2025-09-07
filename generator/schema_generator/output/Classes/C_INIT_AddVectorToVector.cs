using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_AddVectorToVector : CParticleFunctionInitializer, IC_INIT_AddVectorToVector {

  public C_INIT_AddVectorToVector(nint handle) : base(handle) {
  }

  public C_INIT_AddVectorToVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Scale {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xFBD8AC005F596B51));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xFBD8AC00E5729606));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xFBD8AC00AE775669));
  }
  public ref Vector OffsetMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xFBD8AC00ABED1082));
  }
  public ref Vector OffsetMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xFBD8AC0095D96628));
  }
  public IRandomNumberGeneratorParameters RandomnessParameters {
    get => new CRandomNumberGeneratorParameters(_Handle + Schema.GetOffset(0xFBD8AC007EDF50AD));
  }


}