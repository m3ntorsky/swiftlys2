using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_CycleScalar : CParticleFunctionOperator, IC_OP_CycleScalar {

  public C_OP_CycleScalar(nint handle) : base(handle) {
  }

  public C_OP_CycleScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t DestField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8E3188612E3589F3));
  }
  public ref float StartValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E31886151C82C2A));
  }
  public ref float EndValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E3188616EDBBCD5));
  }
  public ref float CycleTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E3188619EE036CE));
  }
  public ref bool DoNotRepeatCycle {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E318861B2E181D4));
  }
  public ref bool SynchronizeParticles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E31886132C4244C));
  }
  public ref int CPScale {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8E318861048A0408));
  }
  public ref int CPFieldMin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8E3188613B60DFC2));
  }
  public ref int CPFieldMax {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8E318861254D3568));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x8E318861FB53C31E));
  }


}