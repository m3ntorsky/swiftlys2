using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapAverageHitboxSpeedtoCP : IParticleFunctionPreEmission {

  public ref int InControlPointNumber { get; }
  
  public ref int OutControlPointNumber { get; }
  
  public ref int Field { get; }
  
  public ref ParticleHitboxDataSelection_t HitboxDataType { get; }
  
  public IParticleCollectionFloatInput InputMin { get; }
  
  public IParticleCollectionFloatInput InputMax { get; }
  
  public IParticleCollectionFloatInput OutputMin { get; }
  
  public IParticleCollectionFloatInput OutputMax { get; }
  
  public ref int HeightControlPointNumber { get; }
  
  public IParticleCollectionVecInput ComparisonVelocity { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
}