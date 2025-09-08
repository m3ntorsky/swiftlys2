using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateOnModel : IParticleFunctionInitializer {

  public IParticleModelInput ModelInput { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public ref int ForceInModel { get; }
  
  public ref bool ScaleToVolume { get; }
  
  public ref bool EvenDistribution { get; }
  
  public IParticleCollectionFloatInput DesiredHitbox { get; }
  
  public ref int HitboxValueFromControlPointIndex { get; }
  
  public IParticleCollectionVecInput HitBoxScale { get; }
  
  public ref float BoneVelocity { get; }
  
  public ref float MaxBoneVelocity { get; }
  
  public IParticleCollectionVecInput DirectionBias { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
  public ref bool LocalCoords { get; }
  
  public ref bool UseBones { get; }
  
  public ref bool UseMesh { get; }
  
  public IParticleCollectionFloatInput ShellSize { get; }
  
}