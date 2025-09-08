using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomVector : CParticleFunctionInitializer, IC_INIT_RandomVector {

  public C_INIT_RandomVector(nint handle) : base(handle) {
  }

  public ref Vector Min {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9B672752B0765F37));
  }
  public ref Vector Max {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9B672752BE89FCF9));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x9B672752E5729606));
  }
  public IRandomNumberGeneratorParameters RandomnessParameters {
    get => new CRandomNumberGeneratorParameters(_Handle + Schema.GetOffset(0x9B6727527EDF50AD));
  }


}