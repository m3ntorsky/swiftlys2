using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateWithinBox : CParticleFunctionInitializer, IC_INIT_CreateWithinBox {

  public C_INIT_CreateWithinBox(nint handle) : base(handle) {
  }

  public IPerParticleVecInput Min {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x331A2B22B0765F37));
  }
  public IPerParticleVecInput Max {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x331A2B22BE89FCF9));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x331A2B223F31A6BD));
  }
  public ref bool LocalSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x331A2B2262418E6E));
  }
  public IRandomNumberGeneratorParameters RandomnessParameters {
    get => new CRandomNumberGeneratorParameters(_Handle + Schema.GetOffset(0x331A2B227EDF50AD));
  }
  public ref bool UseNewCode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x331A2B227C6D1CDF));
  }


}