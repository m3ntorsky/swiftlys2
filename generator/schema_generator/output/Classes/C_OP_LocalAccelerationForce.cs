using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LocalAccelerationForce : CParticleFunctionForce, IC_OP_LocalAccelerationForce {

  public C_OP_LocalAccelerationForce(nint handle) : base(handle) {
  }

  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3A562A9FEB661472));
  }
  public ref int ScaleCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3A562A9FDE3CC5E6));
  }
  public IParticleCollectionVecInput Accel {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x3A562A9FEA9A0D73));
  }


}