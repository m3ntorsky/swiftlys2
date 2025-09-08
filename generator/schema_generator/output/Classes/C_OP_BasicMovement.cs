using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_BasicMovement : CParticleFunctionOperator, IC_OP_BasicMovement {

  public C_OP_BasicMovement(nint handle) : base(handle) {
  }

  public IParticleCollectionVecInput Gravity {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xC8273B20790C70C5));
  }
  public IParticleCollectionFloatInput Drag {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xC8273B2050DA6497));
  }
  public IParticleMassCalculationParameters MassControls {
    get => new CParticleMassCalculationParameters(_Handle + Schema.GetOffset(0xC8273B2039CBEACB));
  }
  public ref int MaxConstraintPasses {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC8273B20D83D0CAB));
  }
  public ref bool UseNewCode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC8273B207C6D1CDF));
  }


}