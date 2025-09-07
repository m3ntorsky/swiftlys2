using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitFromVectorFieldSnapshot : CParticleFunctionInitializer, IC_INIT_InitFromVectorFieldSnapshot {

  public C_INIT_InitFromVectorFieldSnapshot(nint handle) : base(handle) {
  }

  public C_INIT_InitFromVectorFieldSnapshot(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1F4AA8713F31A6BD));
  }
  public ref int LocalSpaceCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1F4AA871C8E9CB31));
  }
  public ref int WeightUpdateCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1F4AA8712CCDE17F));
  }
  public ref bool UseVerticalVelocity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1F4AA8713C99C6FD));
  }
  public IPerParticleVecInput Scale {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x1F4AA8715F596B51));
  }


}