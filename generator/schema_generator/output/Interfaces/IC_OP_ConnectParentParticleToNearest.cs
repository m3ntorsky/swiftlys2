using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ConnectParentParticleToNearest : IParticleFunctionOperator {

  public ref int FirstControlPoint { get; }
  
  public ref int SecondControlPoint { get; }
  
  public ref bool UseRadius { get; }
  
  public IParticleCollectionFloatInput RadiusScale { get; }
  
  public IParticleCollectionFloatInput ParentRadiusScale { get; }
  
}