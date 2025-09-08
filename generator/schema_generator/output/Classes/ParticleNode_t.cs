using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticleNode_t : SchemaClass, IParticleNode_t {

  public ParticleNode_t(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> Entity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xBECF421C6EBADCB0));
  }
  public IParticleIndex_t Index {
    get => new ParticleIndex_t(_Handle + Schema.GetOffset(0xBECF421C8F270140));
  }
  public IGameTime_t StartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xBECF421C67FE9DC4));
  }
  public ref float GrowthDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBECF421CF0D91F70));
  }
  public ref Vector GrowthOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xBECF421C4A651090));
  }
  public ref float EndcapTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBECF421CCF1342BD));
  }
  public ref bool MarkedForDelete {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBECF421C6C9EC48F));
  }


}