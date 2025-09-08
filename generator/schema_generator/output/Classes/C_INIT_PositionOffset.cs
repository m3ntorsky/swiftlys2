using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_PositionOffset : CParticleFunctionInitializer, IC_INIT_PositionOffset {

  public C_INIT_PositionOffset(nint handle) : base(handle) {
  }

  public IPerParticleVecInput OffsetMin {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x263FD76A7E1ECBDE));
  }
  public IPerParticleVecInput OffsetMax {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x263FD76A9009CD7C));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x263FD76AB3FDC289));
  }
  public ref bool LocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x263FD76A30E716DE));
  }
  public ref bool Proportional {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x263FD76A891F328A));
  }
  public IRandomNumberGeneratorParameters RandomnessParameters {
    get => new CRandomNumberGeneratorParameters(_Handle + Schema.GetOffset(0x263FD76A7EDF50AD));
  }


}