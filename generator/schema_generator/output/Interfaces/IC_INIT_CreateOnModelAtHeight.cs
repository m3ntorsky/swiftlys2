using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateOnModelAtHeight : IParticleFunctionInitializer {

  
  public ref bool UseBones { get; }
  
  public ref bool ForceZ { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref int HeightCP { get; }
  
  public ref bool UseWaterHeight { get; }
  
  public IParticleCollectionFloatInput DesiredHeight { get; }
  
  public IParticleCollectionVecInput HitBoxScale { get; }
  
  public IParticleCollectionVecInput DirectionBias { get; }
  
  public ref ParticleHitboxBiasType_t BiasType { get; }
  
  public ref bool LocalCoords { get; }
  
  public ref bool PreferMovingBoxes { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
  public IParticleCollectionFloatInput HitboxVelocityScale { get; }
  
  public IParticleCollectionFloatInput MaxBoneVelocity { get; }
}