using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetFromCPSnapshot : IParticleFunctionOperator {

  public ref int ControlPointNumber { get; }
  
  public ref CUtlString StrSnapshotSubset { get; }
  
  public IParticleAttributeIndex_t AttributeToRead { get; }
  
  public IParticleAttributeIndex_t AttributeToWrite { get; }
  
  public ref int LocalSpaceCP { get; }
  
  public ref bool Random { get; }
  
  public ref bool Reverse { get; }
  
  public ref int RandomSeed { get; }
  
  public IParticleCollectionFloatInput SnapShotStartPoint { get; }
  
  public IParticleCollectionFloatInput SnapShotIncrement { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
  
  public ref bool SubSample { get; }
  
  public ref bool Prev { get; }
  
}