using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_InstantaneousEmitter : CParticleFunctionEmitter, IC_OP_InstantaneousEmitter {

  public C_OP_InstantaneousEmitter(nint handle) : base(handle) {
  }

  public C_OP_InstantaneousEmitter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput ParticlesToEmit {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x39132039B1A158C6));
  }
  public IParticleCollectionFloatInput StartTime {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x3913203967FE9DC4));
  }
  public ref float InitFromKilledParentParticles {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x39132039269B492F));
  }
  public ref EventTypeSelection_t EventType {
    get => ref _Handle.AsRef<EventTypeSelection_t>(Schema.GetOffset(0x39132039E1F9AA93));
  }
  public IParticleCollectionFloatInput ParentParticleScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x3913203967144ED5));
  }
  public ref int MaxEmittedPerFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3913203970B62EBB));
  }
  public ref int SnapshotControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x39132039192638EC));
  }
  public ref CUtlString StrSnapshotSubset {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x39132039BD8A8E5E));
  }


}