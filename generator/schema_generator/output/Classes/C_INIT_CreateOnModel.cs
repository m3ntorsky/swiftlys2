using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateOnModel : CParticleFunctionInitializer, IC_INIT_CreateOnModel {

  public C_INIT_CreateOnModel(nint handle) : base(handle) {
  }

  public IParticleModelInput ModelInput {
    get => new CParticleModelInput(_Handle + Schema.GetOffset(0xD7E11944EB74120E));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xD7E119443A9ED669));
  }
  public ref int ForceInModel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD7E11944A3C747AC));
  }
  public ref bool ScaleToVolume {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD7E11944306BC482));
  }
  public ref bool EvenDistribution {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD7E1194484932067));
  }
  public IParticleCollectionFloatInput DesiredHitbox {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xD7E11944FD09531B));
  }
  public ref int HitboxValueFromControlPointIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD7E11944885FF607));
  }
  public IParticleCollectionVecInput HitBoxScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xD7E1194458EE3FB7));
  }
  public ref float BoneVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD7E11944B06BD382));
  }
  public ref float MaxBoneVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD7E1194460C6A35A));
  }
  public IParticleCollectionVecInput DirectionBias {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xD7E119445A1697CF));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle, 0xD7E119446A21BB0E, 128, 1, 1);
  }
  public ref bool LocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD7E1194430E716DE));
  }
  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD7E1194410D1938B));
  }
  public ref bool UseMesh {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD7E11944ECDA3B19));
  }
  public IParticleCollectionFloatInput ShellSize {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xD7E1194404D01B22));
  }


}