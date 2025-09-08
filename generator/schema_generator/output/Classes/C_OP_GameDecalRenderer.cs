using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_GameDecalRenderer : CParticleFunctionRenderer, IC_OP_GameDecalRenderer {

  public C_OP_GameDecalRenderer(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol DecalGroupName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x42DAAA6713ADF275));
  }
  public ref EventTypeSelection_t EventType {
    get => ref _Handle.AsRef<EventTypeSelection_t>(Schema.GetOffset(0x42DAAA67E1F9AA93));
  }
  public ref ParticleCollisionMask_t InteractionMask {
    get => ref _Handle.AsRef<ParticleCollisionMask_t>(Schema.GetOffset(0x42DAAA6776E7F97B));
  }
  public ref ParticleCollisionGroup_t CollisionGroup {
    get => ref _Handle.AsRef<ParticleCollisionGroup_t>(Schema.GetOffset(0x42DAAA670AC0C752));
  }
  public IPerParticleVecInput StartPos {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x42DAAA6726654BFF));
  }
  public IPerParticleVecInput EndPos {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x42DAAA678DD24760));
  }
  public IPerParticleFloatInput TraceBloat {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x42DAAA674BE375F2));
  }
  public IPerParticleFloatInput DecalSize {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x42DAAA6788E12609));
  }
  public IPerParticleFloatInput DecalGroupIndex {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x42DAAA6784206313));
  }
  public IPerParticleFloatInput DecalRotation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x42DAAA6788A29A9E));
  }
  public IPerParticleVecInput ModulationColor {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x42DAAA67C39DA78E));
  }
  public ref bool UseGameDefaultDecalSize {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42DAAA6749D51905));
  }
  public ref bool RandomDecalRotation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42DAAA673B9BD1F1));
  }
  public ref bool RandomlySelectDecalInGroup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42DAAA670519A84C));
  }
  public ref bool NoDecalsOnOwner {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42DAAA672B2ECEB4));
  }
  public ref bool VisualizeTraces {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42DAAA67ED707633));
  }


}