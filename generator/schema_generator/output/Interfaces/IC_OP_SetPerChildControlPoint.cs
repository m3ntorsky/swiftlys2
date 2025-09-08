using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetPerChildControlPoint : IParticleFunctionOperator {

  public ref int ChildGroupID { get; }
  
  public ref int FirstControlPoint { get; }
  
  public ref int NumControlPoints { get; }
  
  public IParticleCollectionFloatInput ParticleIncrement { get; }
  
  public IParticleCollectionFloatInput FirstSourcePoint { get; }
  
  public ref bool SetOrientation { get; }
  
  public IParticleAttributeIndex_t OrientationField { get; }
  
  public ref bool NumBasedOnParticleCount { get; }
  
}