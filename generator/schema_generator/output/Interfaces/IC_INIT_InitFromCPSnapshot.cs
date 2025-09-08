using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitFromCPSnapshot : IParticleFunctionInitializer {

  public ref int ControlPointNumber { get; }
  
  public ref CUtlString StrSnapshotSubset { get; }
  
  public IParticleAttributeIndex_t AttributeToRead { get; }
  
  public IParticleAttributeIndex_t AttributeToWrite { get; }
  
  public ref int LocalSpaceCP { get; }
  
  public ref bool Random { get; }
  
  public ref bool Reverse { get; }
  
  public IParticleCollectionFloatInput SnapShotIncrement { get; }
  
  public IPerParticleFloatInput ManualSnapshotIndex { get; }
  
  public ref int RandomSeed { get; }
  
  public ref bool LocalSpaceAngles { get; }
  
}