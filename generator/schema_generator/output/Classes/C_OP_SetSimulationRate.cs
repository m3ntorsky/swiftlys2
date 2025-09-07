using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetSimulationRate : CParticleFunctionPreEmission, IC_OP_SetSimulationRate {

  public C_OP_SetSimulationRate(nint handle) : base(handle) {
  }

  public C_OP_SetSimulationRate(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput SimulationScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6C806DC2994DAEC6));
  }


}