using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointToCPVelocity : CParticleFunctionPreEmission, IC_OP_SetControlPointToCPVelocity {

  public C_OP_SetControlPointToCPVelocity(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointToCPVelocity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CPInput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8D70A057FB805736));
  }
  public ref int CPOutputVel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8D70A0576AC86D06));
  }
  public ref bool Normalize {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8D70A05748BC424C));
  }
  public ref int CPOutputMag {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8D70A05704FD82D2));
  }
  public ref int CPField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8D70A05750B79876));
  }
  public IParticleCollectionVecInput ComparisonVelocity {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x8D70A05723BF409F));
  }


}