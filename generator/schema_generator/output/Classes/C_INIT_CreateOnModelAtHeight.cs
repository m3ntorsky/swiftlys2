using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateOnModelAtHeight : CParticleFunctionInitializer, IC_INIT_CreateOnModelAtHeight {

  public C_INIT_CreateOnModelAtHeight(nint handle) : base(handle) {
  }

  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBB8B79F610D1938B));
  }
  public ref bool ForceZ {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBB8B79F6A3DF359A));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBB8B79F63F31A6BD));
  }
  public ref int HeightCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBB8B79F6943E048D));
  }
  public ref bool UseWaterHeight {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBB8B79F616CA1A0C));
  }
  public IParticleCollectionFloatInput DesiredHeight {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xBB8B79F6D72286F4));
  }
  public IParticleCollectionVecInput HitBoxScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xBB8B79F658EE3FB7));
  }
  public IParticleCollectionVecInput DirectionBias {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xBB8B79F65A1697CF));
  }
  public ref ParticleHitboxBiasType_t BiasType {
    get => ref _Handle.AsRef<ParticleHitboxBiasType_t>(Schema.GetOffset(0xBB8B79F65FAB0448));
  }
  public ref bool LocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBB8B79F630E716DE));
  }
  public ref bool PreferMovingBoxes {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBB8B79F68F1573EE));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle, 0xBB8B79F66A21BB0E, 128, 1, 1);
  }
  public IParticleCollectionFloatInput HitboxVelocityScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xBB8B79F65BE2EDCC));
  }
  public IParticleCollectionFloatInput MaxBoneVelocity {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xBB8B79F660C6A35A));
  }


}