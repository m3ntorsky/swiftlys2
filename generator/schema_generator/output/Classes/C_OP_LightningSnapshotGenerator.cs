using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LightningSnapshotGenerator : CParticleFunctionPreEmission, IC_OP_LightningSnapshotGenerator {

  public C_OP_LightningSnapshotGenerator(nint handle) : base(handle) {
  }

  public C_OP_LightningSnapshotGenerator(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CPSnapshot {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA39272CA86FAC63E));
  }
  public ref int CPStartPnt {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA39272CA7731321C));
  }
  public ref int CPEndPnt {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA39272CA3DC6A687));
  }
  public IParticleCollectionFloatInput Segments {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CAE1250039));
  }
  public IParticleCollectionFloatInput Offset {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CA7F14BA34));
  }
  public IParticleCollectionFloatInput OffsetDecay {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CAAFC14FD2));
  }
  public IParticleCollectionFloatInput RecalcRate {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CA4DBA63D9));
  }
  public IParticleCollectionFloatInput UVScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CA8A5EA9EA));
  }
  public IParticleCollectionFloatInput UVOffset {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CA7AD49A5B));
  }
  public IParticleCollectionFloatInput SplitRate {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CA39B025CF));
  }
  public IParticleCollectionFloatInput BranchTwist {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CA688D5606));
  }
  public ref ParticleLightnintBranchBehavior_t BranchBehavior {
    get => ref _Handle.AsRef<ParticleLightnintBranchBehavior_t>(Schema.GetOffset(0xA39272CA04846BB3));
  }
  public IParticleCollectionFloatInput RadiusStart {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CA113E55B7));
  }
  public IParticleCollectionFloatInput RadiusEnd {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CADA05AE12));
  }
  public IParticleCollectionFloatInput DedicatedPool {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA39272CA86FD95A2));
  }


}