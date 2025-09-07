using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ContinuousEmitter : CParticleFunctionEmitter, IC_OP_ContinuousEmitter {

  public C_OP_ContinuousEmitter(nint handle) : base(handle) {
  }

  public C_OP_ContinuousEmitter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput EmissionDuration {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6B2A982090181C90));
  }
  public IParticleCollectionFloatInput StartTime {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6B2A982067FE9DC4));
  }
  public IParticleCollectionFloatInput EmitRate {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6B2A982062DC20CE));
  }
  public ref float EmissionScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6B2A982053003112));
  }
  public ref float ScalePerParentParticle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6B2A98206A172D20));
  }
  public ref bool InitFromKilledParentParticles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6B2A98204B2E40E9));
  }
  public ref EventTypeSelection_t EventType {
    get => ref _Handle.AsRef<EventTypeSelection_t>(Schema.GetOffset(0x6B2A9820E1F9AA93));
  }
  public ref int SnapshotControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6B2A9820192638EC));
  }
  public ref CUtlString StrSnapshotSubset {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6B2A9820BD8A8E5E));
  }
  public ref int LimitPerUpdate {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6B2A98204975B526));
  }
  public ref bool ForceEmitOnFirstUpdate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6B2A98206532DDA9));
  }
  public ref bool ForceEmitOnLastUpdate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6B2A98206498635F));
  }


}